using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace bankApp_
{
    public partial class Form1 : Form
    {
        byte select = 3;
        double money = 100.89, comma;
        int pass, passDB = 7572;
        string input, passT;
        bool click = false, click1 = false, correct = false;

        public Form1()
        {
            InitializeComponent();
            window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            "____________\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            withdrawal.Enabled = false;
            deposit.Enabled = false;
            balance.Enabled = false;
        }

        private void withdrawal_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button0.Enabled = true;
            button00.Enabled = true;
            button_.Enabled = true;

            accept.Enabled = true;
            delete.Enabled = true;
            cancel.Enabled = true;

            select = 0;
            withdrawal.Enabled = false;

            window.Text = "\n" +
            "Money In Your Account\n" +
            "\n" +
            money + "\n" +
            "\n" +
            "Please Write The Amount\n" +
            "____________\n" +
            "                                   Deposit\n" +
            "\n" +
            "                                   Balance\n" +
            "\n" +
            "                                   Exit\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = input + "1";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select==2 && click1==false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input = input + "4";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button0.Enabled = true;
            button00.Enabled = true;
            button_.Enabled = true;

            accept.Enabled = true;
            delete.Enabled = true;
            cancel.Enabled = true;

            select = 1;
            withdrawal.Enabled = false;

            if (click == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                 money + "\n" +
                 "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                              Withdrawal\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
                click = true;
            }
            else if (select == 1 || click == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
                click = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input = input + "3";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void balance_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button0.Enabled = false;
            button00.Enabled = false;
            button_.Enabled = false;

            withdrawal.Enabled = false;

            accept.Enabled = false;
            delete.Enabled = false;
            cancel.Enabled = false;

            select = 2;
            if (select == 2 && click1 == false)
            {
                accept.Enabled = false;
                delete.Enabled = false;
                cancel.Enabled = false;

                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "\n" +
                "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                              Withdrawal\n" +
                "\n" +
                "                                   Exit\n";
                click1 = true;
            }
            else if (select==2 && click1 == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button0.Enabled = true;
                button00.Enabled = true;
                button_.Enabled = true;

                accept.Enabled = true;
                delete.Enabled = true;
                cancel.Enabled = true;

                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
                click1 = false;
            }
            else if (select == 1 && click1 == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button0.Enabled = true;
                button00.Enabled = true;
                button_.Enabled = true;

                accept.Enabled = true;
                delete.Enabled = true;
                cancel.Enabled = true;

                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                              Withdrawal\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
                click1 = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = input + "2";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input = input + "5";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input = input + "6";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input = input + "7";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input = input + "8";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input = input + "9";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button__Click(object sender, EventArgs e)
        {
            input = input + ".";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input = input + "0";
            passT = passT + "*";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            input = input + "00";
            passT = passT + "**";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                window.Text = "\n" +
            "WELCOME TO DYBANK\n" +
            "\n" +
            "Please Enter Your Password\n" +
            "\n" +
            "\n" +
            "\n" +
            passT + "\n" +
            "\n" +
            "\n" +
            "\n" +
            "                                   Exit\n";
            }
            else if (select == 2 && click1 == false)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string number = "";
            for (int i = 0; i < input.Length; i++)
            {

                if ( input[i] == '.' || input[i] == ',')
                {
                    comma = input.Length - (i + 1);
                }
                else
                {
                    number = number + input[i];
                }
            }
            double zero = Math.Pow(10, comma);
            double input_ = Convert.ToDouble(number) / zero;

            if (select == 0 || click == false && correct == true)
            {
                money = money - input_;
            }
            else if (select == 1)
            {
                money = money + input_;
            }
            else
            {
                pass = Convert.ToInt32(input);

            }
            input = "";
            passT = "";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               "____________\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                if (pass==passDB)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button0.Enabled = false;
                    button00.Enabled = false;
                    button_.Enabled = false;

                    accept.Enabled = false;
                    delete.Enabled = false;
                    cancel.Enabled = false;

                    withdrawal.Enabled = true;
                    deposit.Enabled = true;
                    balance.Enabled = true;
                    correct = true;

                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                              Withdrawal\n" +
                    "\n" +
                    "                                   Deposit\n" +
                    "\n" +
                    "                                   Balance\n" +
                    "\n" +
                "                                   Exit\n";
                }
                else
                {
                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "Please Enter Your Password\n" +
                    "\n" +
                    "Wrong Password\n" +
                    "\n" +
                    "____________\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                                   Exit\n";
                }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            input = "";
            passT = "";

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                "____________\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               "____________\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                if (pass == passDB)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button0.Enabled = false;
                    button00.Enabled = false;
                    button_.Enabled = false;

                    accept.Enabled = false;

                    withdrawal.Enabled = true;
                    deposit.Enabled = true;
                    balance.Enabled = true;
                    correct = true;

                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                              Withdrawal\n" +
                    "\n" +
                    "                                   Deposit\n" +
                    "\n" +
                    "                                   Balance\n" +
                    "\n" +
                "                                   Exit\n";
                }
                else
                {
                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "Please Enter Your Password\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "____________\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                                   Exit\n";
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            input = input.Substring(0, input.Length - 1);
            passT = passT.Substring(0, passT.Length - 1);

            if (select == 0 || click == false && correct == true)
            {
                window.Text = "\n" +
                "Money In Your Account\n" +
                "\n" +
                money + "\n" +
                "\n" +
                "Please Write The Amount\n" +
                input + "\n" +
                "                                   Deposit\n" +
                "\n" +
                "                                   Balance\n" +
                "\n" +
                "                                   Exit\n";
            }
            else if (select == 1)
            {
                window.Text = "\n" +
               "Money In Your Account\n" +
               "\n" +
                money + "\n" +
                "\n" +
               "Please Write The Amount\n" +
               input + "\n" +
               "                              Withdrawal\n" +
               "\n" +
               "                                   Balance\n" +
               "\n" +
               "                                   Exit\n";
            }
            else if (select == 3 && correct == false)
            {
                if (pass == passDB)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button0.Enabled = false;
                    button00.Enabled = false;
                    button_.Enabled = false;

                    accept.Enabled = false;

                    withdrawal.Enabled = true;
                    deposit.Enabled = true;
                    balance.Enabled = true;
                    correct = true;

                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                              Withdrawal\n" +
                    "\n" +
                    "                                   Deposit\n" +
                    "\n" +
                    "                                   Balance\n" +
                    "\n" +
                "                                   Exit\n";
                }
                else
                {
                    window.Text = "\n" +
                    "WELCOME TO DYBANK\n" +
                    "\n" +
                    "Please Enter Your Password\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    passT + "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                                   Exit\n";
                }

            }
        }
    }
}