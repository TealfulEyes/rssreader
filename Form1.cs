using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace RssReader
{
    public partial class Rss : Form
    {
        public Rss()
        {
            InitializeComponent();
        }

        String[,] rssData = null;


        private String[,] getRssData(String channel)
        {
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
                System.Net.WebResponse webResponse = myRequest.GetResponse();

                System.IO.Stream rssStream = webResponse.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

                rssDoc.Load(rssStream);

                System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                String[,] tempInfo = new String[500, 3];

                for (int i = 0; i < rssItems.Count; i++)
                {
                    System.Xml.XmlNode rssNode;

                    rssNode = rssItems.Item(i).SelectSingleNode("title");
                    if (rssNode != null)
                    {
                        tempInfo[i, 0] = rssNode.InnerText;
                    }
                    else
                    {
                        tempInfo[i, 0] = "";
                    }
                    rssNode = rssItems.Item(i).SelectSingleNode("description");
                    if (rssNode != null)
                    {
                        tempInfo[i, 1] = rssNode.InnerText;
                    }
                    else
                    {
                        tempInfo[i, 1] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("link");
                    if (rssNode != null)
                    {
                        tempInfo[i, 2] = rssNode.InnerText;
                    }
                    else
                    {
                        tempInfo[i, 2] = "";
                    }
                }
                return tempInfo;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo rssLink = new ProcessStartInfo(rssData[titlesComboBox.SelectedIndex, 2]);
            rssLink.UseShellExecute = true;
            if (rssData[titlesComboBox.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssLink);

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            titlesComboBox.Items.Clear();
            rssData = getRssData(channelTextBox.Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    titlesComboBox.Items.Add(rssData[i, 0]);
                }
                titlesComboBox.SelectedIndex = 0;
            }
        }

        private void titlesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[titlesComboBox.SelectedIndex, 1] != null)
                descriptionTextBox.Text = rssData[titlesComboBox.SelectedIndex, 1];
            if (rssData[titlesComboBox.SelectedIndex, 2] != null)
                linkLabel.Text = rssData[titlesComboBox.SelectedIndex, 0];
        }
    }
}