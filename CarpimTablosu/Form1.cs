using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYardir_Click(object sender, EventArgs e)
        {
            clearViews();
            mBirler();
            mIkiler();
            mUcler();
            mDortler();
            mBesler();
            mAltilar();
            mYediler();
            mSekizler();
            mDokuzlar();
            mOnlar();
        }

        private void mBirler()
        {
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    birler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mIkiler()
        {
            for (int i = 2; i <= 2; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    ikiler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mUcler()
        {
            for (int i = 3; i <= 3; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    ucler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mDortler()
        {
            for (int i = 4; i <= 4; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    dortler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mBesler()
        {
            for (int i = 5; i <= 5; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    besler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mAltilar()
        {
            for (int i = 6; i <= 6; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    altilar.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mYediler()
        {
            for (int i = 7; i <= 7; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    yediler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mSekizler()
        {
            for (int i = 8; i <= 8; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    sekizler.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mDokuzlar()
        {
            for (int i = 9; i <= 9; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    dokuzlar.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void mOnlar()
        {
            for (int i = 4; i <= 4; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int sonuc = i * j;
                    onlar.Items.Add(i + "X" + j + "=" + sonuc);
                }
            }
        }

        private void clearViews()
        {
            birler.Items.Clear();
            ikiler.Items.Clear();
            ucler.Items.Clear();
            dortler.Items.Clear();
            besler.Items.Clear();
            altilar.Items.Clear();
            yediler.Items.Clear();
            sekizler.Items.Clear();
            dokuzlar.Items.Clear();
            onlar.Items.Clear();
        }
    }
}
