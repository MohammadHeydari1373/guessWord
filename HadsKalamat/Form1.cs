using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace HadsKalamat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Var
        SoundPlayer mediaSoundPlayer = new SoundPlayer();
        private string List = "";
        List<Label> labels = new List<Label>(); 
        private string word = "";
        private int count = 0; 
        
        #endregion
        #region Enum Rregion
        enum Parts
        {
            Dar, Head , Shirt,Legs,HeadFeet,Shoes,Eyes
        }  


        #endregion
        #region  DrawBodyParts
        private void DrawBodyParts(Parts bp)
        {   if (bp == Parts.Dar)
            picBoxPart.Image = Properties.Resources._1;
        else if (bp == Parts.Head)
            picBoxPart.Image = Properties.Resources._2;
        else if (bp == Parts.Shirt)
            picBoxPart.Image = Properties.Resources._3;
        else if (bp == Parts.Legs)
            picBoxPart.Image = Properties.Resources._4;
        else if (bp == Parts.HeadFeet)
            picBoxPart.Image = Properties.Resources._5;
        else if (bp == Parts.Shoes)
            picBoxPart.Image = Properties.Resources._6;
        else if (bp == Parts.Eyes)
            picBoxPart.Image = Properties.Resources._7;
        }

        #endregion
        #region GetRandomWord

        private string GetRandomWord()
        {   
            List  = File.ReadAllText("word.txt",Encoding.UTF8) ; 
            
            string[] word = List.Split('\n') ;
            Random rand = new Random();
            string Word1 = word[rand.Next(0, word.Length - 1)];
            

            if (Word1 == word[0])
            {
                lblNew.Text = " آن چیست که روز را کنار پنجره می گذراند، و هنگام غذا کنار میز است و شب ها ناپدید می شود؟";

            }
            if (Word1 == word[1])
            {
                lblNew.Text = "این چیه که مورچه داره ، اما مار نداره ؟";

            }
            if (Word1 == word[2])
            {
                lblNew.Text = "برگ سبز چمنی، ورق ورق تو می شکنی؟";

            }
            if (Word1 == word[3])
            {
                lblNew.Text = "آن چیست که جان دارد و نفس نمی کشد؟";

            }
            if (Word1 == word[4])
            {
                lblNew.Text = "آن چیست که پر دارد و پرواز نمی کند؟";

            }
            if (Word1 == word[5])
            {
                lblNew.Text = " کدام رازداری است که تا سرش را نبریم رازش را نمی گوید؟";

            }
            if (Word1 == word[6])
            {
                lblNew.Text = " سازنده این بازی کیست ؟";

            }
            if (Word1 == word[7])
            {
                lblNew.Text = " ﺍﻭﻥ ﭼﻴﻪ ﺩﻭ ﺣﺮﻓﻴﻪ، ﻛﺮﺩﻧﻴﻪ ﺣﺮﻑ ﺩومش هم «ﺱ» ؟";

            }
            if (Word1 == word[8])
            {
                lblNew.Text = "اﻭﻥ ﭼﻴﻪ ﺳﻪ ﺣﺮﻓﻴﻪ ﺣﺮﻑ ﺳﻮﻣﺶ «ﺭ» ﻫﻤﻪ ﻫﻢ ﺩﺭﺍﺯشو ﺩﻭﺳﺖ ﺩﺍﺭﻥ؟";

            }
            if (Word1 == word[9])
            {
                lblNew.Text = " اگر سر پرگار گیج برود چه می‌کشد؟";

            }
            if (Word1 == word[10])
            {
                lblNew.Text = "اگر شما به من غذا بدهید، من زندگی می کنم. اگر به من نوشیدنی بدهی، من می میرم. من چی هستم؟";

            }
           
            return Word1;
            

         
           // return Word1; 
        }
        #endregion
        #region make label 
         void makeLabel()
        {
            word = GetRandomWord();

            char[] chars = word.ToCharArray();
            int between = 300 / chars.Length - 1;
            for (int i = 0; i < chars.Length-1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point(i * between + 20, 60);
                labels[i].Text = "_";
                labels[i].Parent = groupBxBala; 
                labels[i].BringToFront();
                
                labels[i].CreateControl();
                
                labels[i].Font = new Font("tahoma", 14); 


            }
            lblTedad.Text = "تعداد حروف : "+(chars.Length-1).ToString(); 
             
        }
        #endregion

         private void Form1_Shown(object sender, EventArgs e)
         {
             makeLabel();
         }
         #region button Logic
         private void btnHadsKalame_Click(object sender, EventArgs e)
         {
             
             try
             {
                 char letter = txtKalame.Text.ToLower().ToCharArray()[0];
                 if (!char.IsLetter(letter))
                 {
                     string Location = @"error.wav";
                     mediaSoundPlayer.SoundLocation = Location;
                     mediaSoundPlayer.Play();
                     MessageBox.Show("فقط باید حرف را وارد کنید : ", "اخطار",MessageBoxButtons.OK , MessageBoxIcon.Error );
                     txtKalame.Text = null; 
                 }
                 else if(word.Contains(letter))
                 {
                     string Location = @"Backs.wav";
                     mediaSoundPlayer.SoundLocation = Location;
                     mediaSoundPlayer.Play();
                     char[] letters = word.ToCharArray();
                     for (int i = 0; i < letters.Length-1; i++)
                     {
                         if (letters[i] == letter)
                         
                             labels[i].Text = letter.ToString();
                             picBoxAnswer.Image = Properties.Resources.okay;
                             txtKalame.Text = null;
                            
                     }
                         foreach (Label l in labels)
                         
                             if (l.Text == "_")
                             
                                 return;
                             
                         
                         Location = @"win.wav";
                         mediaSoundPlayer.SoundLocation = Location;
                         mediaSoundPlayer.Play();
                         MessageBox.Show("شما برنده شدید" ,"تبریک " ,MessageBoxButtons.OK , MessageBoxIcon.Information );
                         reset() ; 

                     
                 }
                    else
                 {
                     //کلمات اشتباه و ساخته شدن طناب دار
                     string Location = @"steak.wav";
                     mediaSoundPlayer.SoundLocation = Location;
                     mediaSoundPlayer.Play();
                     picBoxAnswer.Image = Properties.Resources.wrong;
                     lblWrong.Text +=letter.ToString() + " , ";
                     txtKalame.Text = null;
                     DrawBodyParts((Parts)count);
                       
                     count++;
                     //حالت باخت
                     if (count==7)
                     {
                         Location = @"lose.wav";
                     mediaSoundPlayer.SoundLocation = Location;
                     mediaSoundPlayer.Play();
                     MessageBox.Show("متاسفانه شما باختید ", "مرگ ", MessageBoxButtons.OK, MessageBoxIcon.Stop);    
                         reset() ;
                         count = 0; 
                     }
                     else 
                     {
                         if(txtKalame.Text == null)
                         {
                         return;
                         }
                     }

                 }

                 }
                
             
             catch 
             {

                 MessageBox.Show("حتما باید یک کلمه باید واردکنید ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

             }
 
         }
#endregion
     
         private void groupBxBala_Enter(object sender, EventArgs e)
         {

         }

         #region reset
         private void reset()
         {
             picBoxPart.Image = null;
             picBoxAnswer.Image = null;
             lblWrong.Text = null;
             GetRandomWord();
            // lblNew.Text = null;
             lblTedad.Text = null;
             count = 0;


             makeLabel();
         }
         #endregion

         private void بازیجدیدToolStripMenuItem_Click(object sender, EventArgs e)
         {
             reset();
             count = 0;
         }
    }
}
