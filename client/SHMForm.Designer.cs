namespace SHM
{
    partial class SHMForm
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
            this.accessMemoryMap = new System.Windows.Forms.Button();
            this.memoryMapName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value3 = new System.Windows.Forms.TextBox();
            this.value4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.value5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setMemoryValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accessMemoryMap
            // 
            this.accessMemoryMap.Location = new System.Drawing.Point(197, 10);
            this.accessMemoryMap.Name = "accessMemoryMap";
            this.accessMemoryMap.Size = new System.Drawing.Size(44, 23);
            this.accessMemoryMap.TabIndex = 0;
            this.accessMemoryMap.Text = "접근";
            this.accessMemoryMap.UseVisualStyleBackColor = true;
            this.accessMemoryMap.Click += new System.EventHandler(this.accessMemoryMap_Click);
            // 
            // memoryMapName
            // 
            this.memoryMapName.Location = new System.Drawing.Point(83, 10);
            this.memoryMapName.Name = "memoryMapName";
            this.memoryMapName.Size = new System.Drawing.Size(108, 21);
            this.memoryMapName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "메모리맵";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value2";
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(83, 59);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(158, 21);
            this.value1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value3";
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(83, 89);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(158, 21);
            this.value2.TabIndex = 7;
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(83, 119);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(158, 21);
            this.value3.TabIndex = 8;
            // 
            // value4
            // 
            this.value4.Location = new System.Drawing.Point(83, 146);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(158, 21);
            this.value4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Value4";
            // 
            // value5
            // 
            this.value5.Location = new System.Drawing.Point(83, 173);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(158, 21);
            this.value5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value5";
            // 
            // setMemoryValue
            // 
            this.setMemoryValue.Location = new System.Drawing.Point(26, 200);
            this.setMemoryValue.Name = "setMemoryValue";
            this.setMemoryValue.Size = new System.Drawing.Size(215, 23);
            this.setMemoryValue.TabIndex = 13;
            this.setMemoryValue.Text = "메모리 값 변경";
            this.setMemoryValue.UseVisualStyleBackColor = true;
            this.setMemoryValue.Click += new System.EventHandler(this.setMemoryValue_Click);
            // 
            // SHMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 236);
            this.Controls.Add(this.setMemoryValue);
            this.Controls.Add(this.value5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoryMapName);
            this.Controls.Add(this.accessMemoryMap);
            this.Name = "SHMForm";
            this.Text = "공유 메모리 설정";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accessMemoryMap;
        private System.Windows.Forms.TextBox memoryMapName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.TextBox value4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox value5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setMemoryValue;
    }
}

