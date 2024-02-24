using RestSharp.Authenticators;
using RestSharp;
using System.Threading;
using jsondecoder.Models;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using Activity = jsondecoder.Models.Activity;
using System;
using Microsoft.VisualBasic.Logging;
using System.Net;

namespace jsondecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        RestClient client;
        AccessTokenResponse accessTokenResponse;
        ProjectInfoWeeklyWithPeriodsResponse projectInfoWeeklyWithPeriodsResponse;
        UserInfo userInfo;
        UploadModel uploadModel;
        string sasUri;
        Period period;
        string Url_UploadData = "https://app.monitask.com/api/v2/Deskcap/UploadData";
        string Url_Login = "https://app.monitask.com/token";
        string Url_GetProjectInfoWeeklyWithPeriods = "https://app.monitask.com/api/v2/Deskcap/GetProjectInfoWeeklyWithPeriods";
        string Url_UrlInfo = "https://app.monitask.com/api/v2/Deskcap/UrlInfo";
        string Url_GetUserInfo = "https://app.monitask.com/api/v2/Deskcap/GetUserInfo";
        string Url_GetContainerSasV2 = "https://app.monitask.com/api/v2/Deskcap/GetContainerSasV2";
        string Url_ImageDetails = "https://app.monitask.com/api/v2/Deskcap/ImageDetails";


        private void Form1_Load(object sender, EventArgs e)
        {

            client = new RestClient();

            dateTimePicker1.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
            dateTimePicker2.CustomFormat = "yyyy-MM-ddTHH:mm:ss";

            string jsonAccessTokenResponse = Properties.Settings.Default.AccessTokenResponse;

            if (!string.IsNullOrEmpty(jsonAccessTokenResponse))
            {
                accessTokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(jsonAccessTokenResponse);
                label1.Text = $"Hello :  {accessTokenResponse.FirstName}";
                GetProjectInfoWeeklyWithPeriods();
                GetUserInfo();
                GetContainerSasV2();
            }

            period = JsonConvert.DeserializeObject<Period>(textBox1.Text);

        }
        private async void GetProjectInfoWeeklyWithPeriods()
        {
            var request = new RestRequest(Url_GetProjectInfoWeeklyWithPeriods, Method.Get);
            request.AddHeader("Authorization", $"Bearer {accessTokenResponse.Access_Token}");
            var cancellationToken = new CancellationToken();
            var response = await client.ExecuteAsync(request, cancellationToken);
            projectInfoWeeklyWithPeriodsResponse = JsonConvert.DeserializeObject<ProjectInfoWeeklyWithPeriodsResponse>(response.Content);
            string formattedJson = JsonConvert.SerializeObject(projectInfoWeeklyWithPeriodsResponse, Formatting.Indented);
            txt_json.Text = formattedJson;

        }
        private async void GetUserInfo()
        {
            var request = new RestRequest(Url_GetUserInfo, Method.Get);
            request.AddHeader("Authorization", $"Bearer {accessTokenResponse.Access_Token}");
            var cancellationToken = new CancellationToken();
            var response = await client.ExecuteAsync(request, cancellationToken);
            userInfo = JsonConvert.DeserializeObject<UserInfo>(response.Content);
            string formattedJson = JsonConvert.SerializeObject(userInfo, Formatting.Indented);
            txt_json.Text = formattedJson;

        }

        private async void GetContainerSasV2()
        {
            var request = new RestRequest(Url_GetContainerSasV2, Method.Get);
            request.AddHeader("Authorization", $"Bearer {accessTokenResponse.Access_Token}");
            var cancellationToken = new CancellationToken();
            var response = await client.ExecuteAsync(request, cancellationToken);
            sasUri = JsonConvert.DeserializeObject(response.Content.ToString()).ToString();

        }

        private async void UploadImagesToAzureV2(string fname, byte[] bytes, bool isOrigin, UserInfo storageInfo, DateTime dateTime)
        {

            string[] strArray = sasUri.Split('?');
            string url = isOrigin ? strArray[0] + "/origin/" + storageInfo.UserId : strArray[0] + "/resized/" + storageInfo.UserId;
            RestRequest request = new RestRequest(url + '/' + fname + "?" + strArray[1], Method.Put);
            request.AddHeader("Content-Type", "image/jpg");
            request.AddHeader("Content-Length", bytes.Length.ToString());
            request.AddHeader("x-ms-blob-type", "BlockBlob");
            request.AddHeader("x-ms-date", string.Format("{0:R}", (object)dateTime));
            request.AddParameter("image/jpg", (object)bytes, ParameterType.RequestBody);

            var cancellationToken = new CancellationToken();

            var response = await client.ExecuteAsync(request, cancellationToken);


        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var request = new RestRequest(Url_Login, Method.Post);

            // Add parameters to the request
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", txt_email.Text);
            request.AddParameter("password", txt_password.Text);


            var cancellationToken = new CancellationToken();

            var response = await client.ExecuteAsync(request, cancellationToken);

            accessTokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(response.Content);


            if (response.IsSuccessful)
            {
                txt_json.Text = accessTokenResponse.Access_Token;

                Properties.Settings.Default.AccessTokenResponse = JsonConvert.SerializeObject(accessTokenResponse);

                Properties.Settings.Default.Save();
                label1.Text = $"Hello :  {accessTokenResponse.FirstName}";

            }

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {

            DateTime utcNow = GetUtcDate();
            Guid periodId = Guid.NewGuid();


            List<string> applicationList = new List<string>
        {
            "Webstorm64",
            "Windows Explorer",
            "Google Chrome",
            "Slack",
            "Visual Studio Code",
            "Sublime Text",
            "Docker Desktop",
            "Notepad",
            "Postman",
            "PM2",
            "ApplicationFrameHost",
            "Microsoft Excel"
        };

            period = JsonConvert.DeserializeObject<Period>(textBox1.Text);

            int randomIndex = (new Random()).Next(0, applicationList.Count);


            List<Period> periods = new List<Period>();



            period.Id = periodId;
            period.SessionId = "win_" + (Guid.NewGuid().ToString());



            period.DateStart = period.DateStart.AddDays(int.Parse(numericUpDown1.Text)).AddMinutes(int.Parse(numericUpDown2.Text));
            period.DateEnd = period.DateEnd.AddDays(int.Parse(numericUpDown1.Text)).AddMinutes(int.Parse(numericUpDown2.Text));

            period.DateIntervalStart = period.DateStart;
            period.DateLastActive = period.DateEnd.AddMinutes(-(randomIndex * 2));
            period.DateSave = period.DateEnd;

            TimeSpan duration = period.DateEnd - period.DateStart;

            period.Duration = duration.TotalSeconds;


            period.AppTime.ForEach(appTime =>
            {
                appTime.PeriodId = periodId;
                appTime.Date = RoundDateTime(period.DateStart);
                appTime.Duration = period.Duration;
                appTime.ApplicationName = applicationList[(new Random()).Next(0, applicationList.Count)];
            });

            Random random = new Random();



            period.Activitys.ForEach(activitys =>
                {
                    activitys.Data = new string(Enumerable.Range(1, random.Next(2, 31)).Select(_ => (char)(random.Next(2) + '0')).ToArray()); ;
                    activitys.Date = activitys.Date.AddDays(int.Parse(numericUpDown1.Text)).AddMinutes(int.Parse(numericUpDown2.Text));
                });

            periods.Add(period);

            uploadModel = new UploadModel();
            uploadModel.Periods = periods;

            string jsonPeriods = JsonConvert.SerializeObject(uploadModel, Formatting.Indented);


            txt_json.Text = jsonPeriods;

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            var request = new RestRequest(Url_UploadData, Method.Post);
            request.AddHeader("Authorization", $"Bearer {accessTokenResponse.Access_Token}");
            request.AddJsonBody(txt_json.Text);

            var cancellationToken = new CancellationToken();

            var response = await client.ExecuteAsync(request, cancellationToken);


            if (response.IsSuccessful)
            {
                txt_json.Text = response.Content;

            }

        }

        public async void SendImageUploadConfirmation(List<ImageDetail> imageDetailsList)
        {

            var request = new RestRequest(Url_ImageDetails, Method.Post);
            request.AddHeader("Authorization", $"Bearer {accessTokenResponse.Access_Token}");
            request.AddJsonBody(JsonConvert.SerializeObject(imageDetailsList));

            var cancellationToken = new CancellationToken();

            var response = await client.ExecuteAsync(request, cancellationToken);


            if (response.IsSuccessful)
            {
                txt_json.Text = response.Content;

            }
        }

        private DateTime GetUtcDate()
        {
            //  TimeSpan elapsed = ""; //TimeSpan
            DateTime InitionDate = new DateTime(2024, 02, 15);
            // Set a specific duration for elapsed, for example, 3 days, 5 hours, 30 minutes, and 15 seconds
            TimeSpan elapsed = new TimeSpan(0, 1, 30, 0);
            return DateTime.SpecifyKind(InitionDate.Add(elapsed), DateTimeKind.Utc);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;

        }


        public static DateTime RoundDateTime(DateTime date)
        {
            // Create a new DateTime with the same year, month, and day as the original date,
            // but round down the minutes to the nearest 10-minute interval.
            DateTime roundedDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute - date.Minute % 10, 0);

            // Specify the kind of the resulting DateTime as Utc.
            // This ensures that the resulting DateTime is considered as Coordinated Universal Time (UTC).
            return DateTime.SpecifyKind(roundedDate, DateTimeKind.Utc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Application.StartupPath +"mocks");
                     
            TimeSpan interval = TimeSpan.FromMinutes(10);

            List<ImageDetail> imageDetailsList = new List<ImageDetail>();
            HashSet<int> usedIndices = new HashSet<int>();
            Random random = new Random();

            var availableIndices = Enumerable.Range(0, files.Length).ToList();

            for (DateTime currentTime = period.DateStart; currentTime <= period.DateEnd; currentTime += interval)
            {
                for (int i = 1; i <= random.Next(3,5); i++)
                {
                    int randomIndex = availableIndices.OrderBy(x => random.Next()).First();
                    availableIndices.Remove(randomIndex);

                     
                    DateTime uniqueTime = currentTime.AddMinutes(random.NextDouble() * 10);

                    string str = string.Format("scr{0:yyyyMMddHHmmssfff}.jpg", uniqueTime);
                    ImageDetail imageDetails = new ImageDetail()
                    {
                        Date = uniqueTime,
                        LocalUtcTime = uniqueTime,
                        FileName = str,
                        IsUploaded = false,
                        path = files[randomIndex]

                    };

                    imageDetailsList.Add(imageDetails);
                }
            }
             

            txt_json.Text = JsonConvert.SerializeObject(imageDetailsList, Formatting.Indented);

            foreach (ImageDetail imageDetails in imageDetailsList)
            {
                try
                {
                    byte[] orginal = System.IO.File.ReadAllBytes(imageDetails.path);
                    byte[] resized = ImageService.ResizeImage(orginal);

                    this.UploadImagesToAzureV2(imageDetails.FileName, orginal, true, userInfo, period.DateEnd);
                    this.UploadImagesToAzureV2(imageDetails.FileName, resized, false, userInfo, period.DateEnd);

                    imageDetails.IsUploaded = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Upload" + imageDetails.FileName);
                }

            }

            SendImageUploadConfirmation(imageDetailsList);





        }
    }





}
