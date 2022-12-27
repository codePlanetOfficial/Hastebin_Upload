using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;

namespace Hastebin_Upload
{
    public partial class Form1 : Form
    {
        public void UploadToHastebin()
        {
            // Get the API endpoint URL from the server_url control
            string apiUrl = "https://" + server_url.Text + "/documents";

            // Get the text to be uploaded from the text_box_multiline control
            string text = text_box_multiline.Text;

            // Create a new WebClient instance
            using (WebClient client = new WebClient())
            {
                // Set the content type to "application/json"
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                // Convert the text to a byte array
                byte[] data = Encoding.UTF8.GetBytes(text);

                // Make the POST request to the API endpoint
                byte[] response = client.UploadData(apiUrl, "POST", data);

                // Deserialize the response JSON to a dictionary
                Dictionary<string, string> responseDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Encoding.UTF8.GetString(response));

                // Display the URL of the created paste in the display_textbox control
                display_textbox.Text = "https://" + server_url.Text + "/" + responseDict["key"];
            }
        }

       



        public Form1()
        {
            InitializeComponent();
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            UploadToHastebin();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
