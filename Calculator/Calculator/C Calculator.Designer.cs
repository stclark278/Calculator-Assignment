
namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPowerFunction = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInputHistory = new System.Windows.Forms.TextBox();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.txtCurrentInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(23, 71);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(50, 43);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPowerFunction
            // 
            this.btnPowerFunction.Location = new System.Drawing.Point(79, 71);
            this.btnPowerFunction.Name = "btnPowerFunction";
            this.btnPowerFunction.Size = new System.Drawing.Size(50, 43);
            this.btnPowerFunction.TabIndex = 1;
            this.btnPowerFunction.Text = "x^y";
            this.btnPowerFunction.UseVisualStyleBackColor = true;
            this.btnPowerFunction.Click += new System.EventHandler(this.btnPowerFunction_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(79, 120);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(50, 43);
            this.btnSquareRoot.TabIndex = 2;
            this.btnSquareRoot.Text = "√ x";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(23, 120);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(50, 43);
            this.btnReciprocal.TabIndex = 3;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.Red;
            this.btnClearEntry.Location = new System.Drawing.Point(135, 71);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(50, 43);
            this.btnClearEntry.TabIndex = 4;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(135, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(191, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDivide.Location = new System.Drawing.Point(191, 120);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 43);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Yellow;
            this.btnSeven.Location = new System.Drawing.Point(23, 169);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(50, 43);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Yellow;
            this.btnEight.Location = new System.Drawing.Point(79, 169);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(50, 43);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Yellow;
            this.btnNine.Location = new System.Drawing.Point(135, 169);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(50, 43);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMultiply.Location = new System.Drawing.Point(191, 169);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(65, 43);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Yellow;
            this.btnFour.Location = new System.Drawing.Point(23, 218);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(50, 43);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Yellow;
            this.btnFive.Location = new System.Drawing.Point(79, 218);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(50, 43);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Yellow;
            this.btnSix.Location = new System.Drawing.Point(135, 218);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(50, 43);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSubtract.Location = new System.Drawing.Point(191, 218);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(65, 43);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Yellow;
            this.btnOne.Location = new System.Drawing.Point(23, 267);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(50, 43);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Yellow;
            this.btnTwo.Location = new System.Drawing.Point(79, 267);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(50, 43);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Yellow;
            this.btnThree.Location = new System.Drawing.Point(135, 267);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(50, 43);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(191, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 43);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInputHistory
            // 
            this.txtInputHistory.Location = new System.Drawing.Point(23, 12);
            this.txtInputHistory.Name = "txtInputHistory";
            this.txtInputHistory.Size = new System.Drawing.Size(233, 20);
            this.txtInputHistory.TabIndex = 21;
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.Location = new System.Drawing.Point(23, 316);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(50, 43);
            this.btnPosNeg.TabIndex = 22;
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = true;
            this.btnPosNeg.Click += new System.EventHandler(this.btnPosNeg_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Yellow;
            this.btnZero.Location = new System.Drawing.Point(79, 316);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(50, 43);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(135, 316);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(50, 43);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEqual.Location = new System.Drawing.Point(191, 316);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(65, 43);
            this.btnEqual.TabIndex = 25;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtCurrentInput
            // 
            this.txtCurrentInput.Location = new System.Drawing.Point(143, 38);
            this.txtCurrentInput.Name = "txtCurrentInput";
            this.txtCurrentInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentInput.Size = new System.Drawing.Size(113, 20);
            this.txtCurrentInput.TabIndex = 28;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 376);
            this.Controls.Add(this.txtCurrentInput);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.txtInputHistory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnPowerFunction);
            this.Controls.Add(this.btnSquare);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Name = "frmCalculator";
            this.Text = "C# Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPowerFunction;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInputHistory;
        private System.Windows.Forms.Button btnPosNeg;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox txtCurrentInput;
    }
}

