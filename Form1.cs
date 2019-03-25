// **************************************************************************************
//  Program: LeagueOfDisconnects (League of Legends Ping Checker)
//  Description: Checks your ping for the popular online video game League of Legends in any of their regional servers!
//  Author: Arhum Nayyar (Rummy)
//  Date of Creation: 6/14/15
//  Date of Completion: 6/14/15
// **************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace LeagueOfDisconnects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PingCheck() //this is the main function that will check the ping of the region selected using server.text as the ip and System.Net.NetworkInformation Ping
        {
            Ping p = new Ping();
                PingReply r;
                string s;
                s = server.Text;
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    ping.ForeColor = System.Drawing.Color.Green;
                    ping.Text = r.RoundtripTime.ToString() + " ms" + "\n";
                    if (r.RoundtripTime >= 240)
                    {
                        ping.ForeColor = System.Drawing.Color.Red;
                        ping.Text = r.RoundtripTime.ToString() + " ms" + "\n";
                    }
                    if (r.RoundtripTime >= 135 & r.RoundtripTime < 240)
                    {
                        ping.ForeColor = System.Drawing.Color.Yellow;
                        ping.Text = r.RoundtripTime.ToString() + " ms" + "\n";
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                PingCheck();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //changes the linklabel name as the user slides the bar to change the region
        {
            if (trackBar1.Value == 0)
            {
                linkLabel1.Text = "North America";
                server.Text = "216.52.241.254";
                button1.Visible = true;
            }

            if (trackBar1.Value == 1) {
                linkLabel1.Text = "EU West";
                server.Text = "185.40.64.65";
                button1.Visible = true;
            }

            if (trackBar1.Value == 2)
            {
                linkLabel1.Text = "EU Nordic & East";
                server.Text = "213.155.135.60";
                button1.Visible = true;
            }

            if (trackBar1.Value == 3)
            {
                linkLabel1.Text = "Brazil";
                server.Text = "NO IP FOUND";
                button1.Visible = false;
            }

            if (trackBar1.Value == 4)
            {
                linkLabel1.Text = "Latin America North";
                server.Text = "NO IP FOUND";
                button1.Visible = false;
            }

            if (trackBar1.Value == 5)
            {
                linkLabel1.Text = "Latin America South";
                server.Text = "NO IP FOUND";
                button1.Visible = false;
            }

            if (trackBar1.Value == 6)
            {
                linkLabel1.Text = "Oceania";
                server.Text = "203.50.13.45";
                button1.Visible = true;
            }

            if (trackBar1.Value == 7)
            {
                linkLabel1.Text = "Russia";
                server.Text = "NO IP FOUND";
                button1.Visible = false;
            }

            if (trackBar1.Value == 8)
            {
                linkLabel1.Text = "Turkey";
                server.Text = "NO IP FOUND";
                button1.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //changes the link for the linklabel to show server status webpage
        {
            if (trackBar1.Value == 0)
            {
                Process.Start("http://status.leagueoflegends.com/#na");
            }

            if (trackBar1.Value == 1)
            {
                Process.Start("http://status.leagueoflegends.com/#euw");
            }

            if (trackBar1.Value == 2)
            {
                Process.Start("http://status.leagueoflegends.com/#eune");
            }

            if (trackBar1.Value == 3)
            {
                Process.Start("http://status.leagueoflegends.com/#br");
            }

            if (trackBar1.Value == 4)
            {
                Process.Start("http://status.leagueoflegends.com/#lan");
            }

            if (trackBar1.Value == 5)
            {
                Process.Start("http://status.leagueoflegends.com/#las");
            }

            if (trackBar1.Value == 6)
            {
                Process.Start("http://status.leagueoflegends.com/#oce");
            }

            if (trackBar1.Value == 7)
            {
                Process.Start("http://status.leagueoflegends.com/#ru");
            }

            if (trackBar1.Value == 8)
            {
                Process.Start("http://status.leagueoflegends.com/#tr");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQ faq = new FAQ();
            faq.Show();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug Bug = new Bug();
            Bug.Show();
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No update available"); //ill do this later zzzz
        }
    }
}
