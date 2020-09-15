namespace CalculatorPro
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Express = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(110, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnC_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(8, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(95, 89);
            this.button3.TabIndex = 3;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button4.Location = new System.Drawing.Point(211, 131);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(95, 89);
            this.button4.TabIndex = 4;
            this.button4.Text = "←";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightBlue;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button8.Location = new System.Drawing.Point(313, 131);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button8.Size = new System.Drawing.Size(95, 89);
            this.button8.TabIndex = 8;
            this.button8.Text = "×";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightBlue;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(8, 228);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button9.Size = new System.Drawing.Size(95, 89);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightBlue;
            this.button10.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(110, 228);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button10.Size = new System.Drawing.Size(95, 89);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightBlue;
            this.button11.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(211, 228);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button11.Size = new System.Drawing.Size(95, 89);
            this.button11.TabIndex = 11;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightBlue;
            this.button12.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button12.Location = new System.Drawing.Point(313, 324);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button12.Size = new System.Drawing.Size(95, 89);
            this.button12.TabIndex = 12;
            this.button12.Text = "－";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightBlue;
            this.button13.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(8, 324);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button13.Size = new System.Drawing.Size(95, 89);
            this.button13.TabIndex = 13;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightBlue;
            this.button14.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(110, 324);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button14.Size = new System.Drawing.Size(95, 89);
            this.button14.TabIndex = 14;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightBlue;
            this.button15.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.Location = new System.Drawing.Point(211, 324);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button15.Size = new System.Drawing.Size(95, 89);
            this.button15.TabIndex = 15;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightBlue;
            this.button16.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button16.Location = new System.Drawing.Point(313, 420);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button16.Size = new System.Drawing.Size(95, 89);
            this.button16.TabIndex = 16;
            this.button16.Text = "＋";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightBlue;
            this.button17.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(8, 420);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button17.Size = new System.Drawing.Size(95, 89);
            this.button17.TabIndex = 17;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightBlue;
            this.button18.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.Location = new System.Drawing.Point(110, 420);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button18.Size = new System.Drawing.Size(95, 89);
            this.button18.TabIndex = 18;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LightBlue;
            this.button19.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button19.Location = new System.Drawing.Point(211, 420);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button19.Name = "button19";
            this.button19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button19.Size = new System.Drawing.Size(95, 89);
            this.button19.TabIndex = 19;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightBlue;
            this.button20.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button20.Location = new System.Drawing.Point(313, 516);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button20.Name = "button20";
            this.button20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button20.Size = new System.Drawing.Size(95, 89);
            this.button20.TabIndex = 20;
            this.button20.Text = "＝";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LightBlue;
            this.button21.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button21.Location = new System.Drawing.Point(110, 516);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button21.Name = "button21";
            this.button21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button21.Size = new System.Drawing.Size(95, 89);
            this.button21.TabIndex = 21;
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LightBlue;
            this.button22.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button22.Location = new System.Drawing.Point(313, 228);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button22.Name = "button22";
            this.button22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button22.Size = new System.Drawing.Size(95, 89);
            this.button22.TabIndex = 22;
            this.button22.Text = "÷";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LightBlue;
            this.button23.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.button23.Location = new System.Drawing.Point(8, 516);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button23.Name = "button23";
            this.button23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button23.Size = new System.Drawing.Size(95, 89);
            this.button23.TabIndex = 23;
            this.button23.Text = "±";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LightBlue;
            this.button24.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button24.Location = new System.Drawing.Point(211, 516);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button24.Name = "button24";
            this.button24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button24.Size = new System.Drawing.Size(95, 89);
            this.button24.TabIndex = 24;
            this.button24.Text = ".";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Font = new System.Drawing.Font("맑은 고딕", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.Location = new System.Drawing.Point(8, 66);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(399, 56);
            this.Result.TabIndex = 25;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 26;
            // 
            // Express
            // 
            this.Express.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Express.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Express.Location = new System.Drawing.Point(9, 34);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(399, 24);
            this.Express.TabIndex = 27;
            this.Express.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 616);
            this.Controls.Add(this.Express);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Express;
    }
}

