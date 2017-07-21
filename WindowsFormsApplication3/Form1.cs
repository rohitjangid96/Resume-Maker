using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
            workexperiencepanel.Visible = false;
            educationpanel.Visible = false;
            skillpanel.Visible = false;
            achievementpanel.Visible = false;
            basicpanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            clickherepanel.Visible = false;
            menupanel.Visible = true;
            basicpanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dobtextbox.Text = dateTimePicker1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
            workexperiencepanel.Visible = false;
            educationpanel.Visible = false;
            basicpanel.Visible = false;
            achievementpanel.Visible = false;
            skillpanel.Visible = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
            workexperiencepanel.Visible = false;
            basicpanel.Visible = false;
            skillpanel.Visible = false;
            achievementpanel.Visible = false;
            educationpanel.Visible = true;
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (languageskillstextBox.Text.Equals("INSERT YOUR OBJECTIVE HERE"))
            {
                languageskillstextBox.Text = "";
            }
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox8_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_MouseLeave_1(object sender, EventArgs e)
        {
            if (languageskillstextBox.Text.Equals(""))
            {
                languageskillstextBox.Text = "INSERT YOUR OBJECTIVE HERE";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void workexperiencebutton_Click(object sender, EventArgs e)
        {

        }

        private void workexperiencebutton_Click_1(object sender, EventArgs e)
        {

        }





        private void skillpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workexperiencebutton_Click_4(object sender, EventArgs e)
        {
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
            achievementpanel.Visible = false;
            basicpanel.Visible = false;
            educationpanel.Visible = false;
            skillpanel.Visible = false;
            workexperiencepanel.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void achievementsbutton_Click(object sender, EventArgs e)
        {
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
            basicpanel.Visible = false;
            educationpanel.Visible = false;
            workexperiencepanel.Visible = false;
            skillpanel.Visible = false;
            achievementpanel.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void achievementpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox65_MouseClick(object sender, MouseEventArgs e)
        {
            if (languageskillstextBox.Text.Equals("INSERT A LANGUAGE SKILL (Eg. FLUENT IN ENGLISH ETC.)"))
            {
                languageskillstextBox.Text = "";
            }
        }

        private void textBox65_MouseLeave(object sender, EventArgs e)
        {
            if (languageskillstextBox.Text.Equals(""))
            {
                languageskillstextBox.Text = "INSERT A LANGUAGE SKILL (Eg. FLUENT IN ENGLISH ETC.";
            }
        }

        private void textBox64_MouseClick(object sender, MouseEventArgs e)
        {
            if (languageskillstextBox.Text.Equals("INSERT A TECHNICAL SKILL(Eg. CODING ETC.)"))
            {
                languageskillstextBox.Text = "";
            }
        }

        private void textBox64_MouseLeave(object sender, EventArgs e)
        {
            if (languageskillstextBox.Text.Equals(""))
            {
                languageskillstextBox.Text = "INSERT A TECHNICAL SKILL(Eg. CODING ETC.)";
            }
        }

        private void textBox63_MouseClick(object sender, MouseEventArgs e)
        {
            if (languageskillstextBox.Text.Equals("INSERT YOUR HOBBIES HERE(Eg. POETRY WRITING ETC.)"))
            {
                languageskillstextBox.Text = "";
            }

        }

        private void textBox63_MouseLeave(object sender, EventArgs e)
        {
            if (languageskillstextBox.Text.Equals(""))
            {
                languageskillstextBox.Text = "INSERT YOUR HOBBIES HERE(Eg. POETRY WRITING ETC.)";
            }

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (objectivetextBox.Text.Equals("INSERT YOUR OBJECTIVE HERE"))
            {
                objectivetextBox.Text = "";
            }
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            if (objectivetextBox.Text.Equals(""))
            {
                objectivetextBox.Text = "INSERT YOUR OBJECTIVE HERE";
            }
        }

        private void textBox8_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (languageskillstextBox.Text.Equals("INSERT A LANGUAGE SKILL (Eg. FLUENT IN ENGLISH ETC.)"))
            {
                languageskillstextBox.Text = "";
            }

        }

        private void textBox8_MouseLeave_2(object sender, EventArgs e)
        {
            if (languageskillstextBox.Text.Equals(""))
            {
                languageskillstextBox.Text = "INSERT A LANGUAGE SKILL (Eg. FLUENT IN ENGLISH ETC.)";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (technicalskillstextBox.Text.Equals("INSERT A TECHNICAL SKILL(Eg. CODING ETC.)"))
            {
                technicalskillstextBox.Text = "";
            }
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {

            if (technicalskillstextBox.Text.Equals(""))
            {
                technicalskillstextBox.Text = "INSERT A TECHNICAL SKILL(Eg. CODING ETC.)";
            }
        }

        private void textBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (hobbiestextBox.Text.Equals("INSERT YOUR HOBBIES HERE(Eg. POETRY WRITING ETC.)"))
            {
                hobbiestextBox.Text = "";
            }
        }

        private void textBox10_MouseLeave(object sender, EventArgs e)
        {
            if (hobbiestextBox.Text.Equals(""))
            {
                hobbiestextBox.Text = "INSERT YOUR HOBBIES HERE(Eg. POETRY WRITING ETC.)";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resumemaker_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            achievementpanel.Visible = false;
            skillpanel.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            skillpanel.Visible = false;
            achievementpanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skillpanel.Visible = false;
            workexperiencepanel.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            workexperiencepanel.Visible = false;
            skillpanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            workexperiencepanel.Visible = false;
            educationpanel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            educationpanel.Visible = false;
            workexperiencepanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            educationpanel.Visible = false;
            basicpanel.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            basicpanel.Visible = false;
            educationpanel.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            basicpanel.Visible = false;
            clickherepanel.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            finishpanel.Visible = false;
            achievementpanel.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            achievementpanel.Visible = false;
            finishpanel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

           
            clickherepanel.Visible = false;
            finishpanel.Visible = false;
                achievementpanel.Visible = false;
                basicpanel.Visible = false;
                educationpanel.Visible = false;
                skillpanel.Visible = false;
                workexperiencepanel.Visible = false;
                menupanel.Visible = false;
                resumemaker.Visible = false;
                namelabel.Text = firstnametextbox.Text + " " + lastnametextbox.Text;
                addresstextBox1.Text = addresstextbox.Text;
                emailtextBox1.Text = emailtextbox.Text;
                contactnotextBox1.Text = contactnotextbox.Text;
                websitelinkLabel1.Text = websitetextbox.Text;
                objectivetextBox2.Text = objectivetextBox.Text;

            int a = Convert.ToInt32(yearofpassingtextBox1.Text);
         int b = Convert.ToInt32(yearofpassingtextBox2.Text);
            int c= Convert.ToInt32(yearofpassingtextBox3.Text);

            if (a > b && a > c)
            {
               /* label8.Text = examinationtextBox1.Text;
                nameofinstitutionlabel11.Text = nameofinstitutiontextBox1.Text;
                yeartextBox11.Text = yearofpassingtextBox1.Text;
                percenttextBox11.Text = percentagetextBox1.Text;
                */

                yeartextBox11.Text="Degree in  "+ examinationtextBox1.Text+"  from  "+ nameofinstitutiontextBox1.Text+"  in the year  "+ yearofpassingtextBox1.Text+"  and obtained  " + percentagetextBox1.Text + "  percent  ";

                /*nameofexamtextBox22.Text = examinationtextBox2.Text;
                nameofinstitutionlabel22.Text = nameofinstitutiontextBox2.Text;
                yeartextBox22.Text = yearofpassingtextBox2.Text;
                percenttextBox22.Text = percentagetextBox2.Text;*/
                yeartextBox22.Text = "Passed  " + examinationtextBox2.Text + "  from  " + nameofinstitutiontextBox2.Text + "  in the year  " + yearofpassingtextBox2.Text + "  and obtained  " + percentagetextBox2.Text + "  percent  ";
                /* nameofexamtextBox33.Text = examinationtextBox3.Text;
                 nameofinstitutionlabel33.Text = nameofinstitutiontextBox3.Text;
                 yeartextBox33.Text = yearofpassingtextBox3.Text;
                 percenttextBox33.Text = percentagetextBox3.Text;*/
                yeartextBox33.Text = "Passed  " + examinationtextBox3.Text + "  from  " + nameofinstitutiontextBox3.Text + "  in the year  " + yearofpassingtextBox3.Text + "  and obtained  " + percentagetextBox3.Text + "  percent  ";
            }

            if (b > a && b > c)
            {
                /*label8.Text = examinationtextBox2.Text;
                nameofinstitutionlabel11.Text = nameofinstitutiontextBox2.Text;
                yeartextBox11.Text = yearofpassingtextBox2.Text;
                percenttextBox11.Text = percentagetextBox2.Text;
                */

                yeartextBox11.Text = "Degree in  " + examinationtextBox2.Text + "  from  " + nameofinstitutiontextBox2.Text + "  in the year  " + yearofpassingtextBox2.Text + "  and obtained  " + percentagetextBox2.Text + "  percent  ";

    /*            nameofexamtextBox22.Text = examinationtextBox1.Text;
                nameofinstitutionlabel22.Text = nameofinstitutiontextBox1.Text;
                yeartextBox22.Text = yearofpassingtextBox1.Text;
                percenttextBox22.Text = percentagetextBox1.Text;
                */
                yeartextBox22.Text="Passed  " + examinationtextBox1.Text + "  from  " + nameofinstitutiontextBox1.Text + "  in the year  " + yearofpassingtextBox1.Text + "  and obtained  " + percentagetextBox1.Text + "  percent  ";

                /*nameofexamtextBox33.Text = examinationtextBox3.Text;
                nameofinstitutionlabel33.Text = nameofinstitutiontextBox3.Text;
                yeartextBox33.Text = yearofpassingtextBox3.Text;
                percenttextBox33.Text = percentagetextBox3.Text;
                */

                yeartextBox33.Text="Passed  " + examinationtextBox3.Text + "  from  " + nameofinstitutiontextBox3.Text + "  in the year  " + yearofpassingtextBox3.Text + "  and obtained  " + percentagetextBox3.Text + "  percent  ";
            }

            if (c > a && c > b)
            {
                /* label8.Text = examinationtextBox3.Text;
                 nameofinstitutionlabel11.Text = nameofinstitutiontextBox3.Text;
                 yeartextBox11.Text = yearofpassingtextBox3.Text;
                 percenttextBox11.Text = percentagetextBox3.Text;
                 */

                yeartextBox11.Text = "Degree in  " + examinationtextBox3.Text + "  from  " + nameofinstitutiontextBox3.Text + "  in the year  " + yearofpassingtextBox3.Text + "  and obtained  " + percentagetextBox3.Text + "  percent  ";

                /*nameofexamtextBox22.Text = examinationtextBox2.Text;
                nameofinstitutionlabel22.Text = nameofinstitutiontextBox2.Text;
                yeartextBox22.Text = yearofpassingtextBox2.Text;
                percenttextBox22.Text = percentagetextBox2.Text;*/
                yeartextBox22.Text = "Passed  " + examinationtextBox2.Text + "  from  " + nameofinstitutiontextBox2.Text + "  in the year  " + yearofpassingtextBox2.Text + "  and obtained  " + percentagetextBox2.Text + "  percent  ";
                /*nameofexamtextBox33.Text = examinationtextBox1.Text;
                nameofinstitutionlabel33.Text = nameofinstitutiontextBox1.Text;
                yeartextBox33.Text = yearofpassingtextBox1.Text;
                percenttextBox33.Text = percentagetextBox1.Text;*/
                yeartextBox33.Text="Passed  " + examinationtextBox1.Text + "  from  " + nameofinstitutiontextBox1.Text + "  in the year  " + yearofpassingtextBox1.Text + "  and obtained  " + percentagetextBox1.Text + "  percent  ";
            }

           /* nameofcompanylabel11.Text =nameofcompanytextBox1.Text;
            yojtextBox11.Text =yearofjoiningtextBox1.Text;
            wdtextBox11.Text =workdurationtextBox1.Text;
            positiontextBox11.Text =positiontextBox1.Text;
            */
            nameofcompanylabel11.Text= "Worked at  " + nameofcompanytextBox1.Text+"  from  "+ yearofjoiningtextBox1.Text+"  for  "+ workdurationtextBox1.Text+"  years as  "+ positiontextBox1.Text;


           /* nameofcompanylabel22.Text =nameofcompanytextBox2.Text;
            yojtextBox22.Text =yearofjoiningtextBox2.Text;
            wdtextBox22.Text =workdurationtextBox2.Text;
            positiontextBox22.Text =positiontextBox2.Text;
            */
            nameofcompanylabel22.Text = "Worked at  " + nameofcompanytextBox2.Text + "  from  " + yearofjoiningtextBox2.Text + "  for  " + workdurationtextBox2.Text + "  years as  " + positiontextBox2.Text;


            /* nameofcompanylabel33.Text =nameofcompanytextBox3.Text;
             yojtextBox33.Text =yearofjoiningtextBox3.Text;
             wdtextBox33.Text =workdurationtextBox3.Text;
             positiontextBox33.Text =positiontextBox3.Text;
             */
            nameofcompanylabel33.Text = "Worked at  " + nameofcompanytextBox3.Text + "  from  " + yearofjoiningtextBox3.Text + "  for  " + workdurationtextBox3.Text + "  years as  " + positiontextBox3.Text;


            hobbiestextBox1.Text = hobbiestextBox.Text;
            technicaltextBox1.Text = technicalskillstextBox.Text;
            languagetextBox1.Text = languageskillstextBox.Text;

            /*winnertextBox11.Text = positioncomboBox1.Text;
            noclabel11.Text = nameofcompetitiontextBox1.Text;
            categorytextBox11.Text = ccomboBox1.Text;*/

            winnertextBox11.Text = positioncomboBox1.Text+"  at  "+ nameofcompetitiontextBox1.Text+"  in  "+ ccomboBox1.Text+"  stream  ";

           /* winnertextBox22.Text = positioncomboBox2.Text;
            noclabel22.Text = nameofcompetitiontextBox2.Text;
            categorytextBox22.Text = categorycomboBox2.Text;
            */
            winnertextBox22.Text = positioncomboBox2.Text + "  at  " + nameofcompetitiontextBox2.Text + "  in  " + categorycomboBox2.Text + "  stream  ";

            /*winnertextBox33.Text = positioncomboBox3.Text;
            noclabel33.Text = nameofcompetitiontextBox3.Text;
            categorytextBox33.Text = categorycomboBox3.Text;
            */
            winnertextBox33.Text = positioncomboBox3.Text + "  at  " + nameofcompetitiontextBox3.Text + "  in  " + categorycomboBox3.Text + "  stream  ";









            finalpanel.Visible = true;
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void websitelinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void finalpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void winnertextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Notepad.exe");
        }
    }
}
