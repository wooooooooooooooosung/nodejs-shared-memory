using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SHM
{
    public partial class SHMForm : Form
    {

        public SHMForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("[Log] Window Form Load");
        }

        /// <summary>
        /// 접근 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accessMemoryMap_Click(object sender, EventArgs e)
        {   
            if (App.AccessSHMMap(this.memoryMapName.Text) == true)
            {
                Debug.WriteLine("[Success] Create Memory Map : " + this.memoryMapName.Text);
                MessageBox.Show("[" + this.memoryMapName.Text + "]에 접근하였습니다.", "Access Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int[] memoryMapDatas = App.GetSHMDataValue();
                
                this.value1.Text = memoryMapDatas[0].ToString();
                this.value2.Text = memoryMapDatas[1].ToString();
                this.value3.Text = memoryMapDatas[2].ToString();
                this.value4.Text = memoryMapDatas[3].ToString();
                this.value5.Text = memoryMapDatas[4].ToString();

                Debug.WriteLine("[" + this.memoryMapName.Text + "]의 데이터: " + string.Join(", ", memoryMapDatas), "Access Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                Debug.WriteLine("[Fail] Create Memory Map");
                MessageBox.Show("해당 메모리 맵이 존재하지 않거나, 접근에 실패했습니다.", "Access Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 메모리 값 변경 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setMemoryValue_Click(object sender, EventArgs e)
        {
            if (App.SetSHMDataValue(
                int.Parse(this.value1.Text),
                int.Parse(this.value2.Text),
                int.Parse(this.value3.Text),
                int.Parse(this.value4.Text),
                int.Parse(this.value5.Text)) == true)
            {
                Debug.WriteLine("[Success] Set Memory Map Data Value");
                MessageBox.Show("메모리 맵 데이터 변경 성공", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                Debug.WriteLine("[Fail] Set Memory Map Data Value");
                MessageBox.Show("해당 메모리 맵이 존재하지 않거나, 데이터 변경에 실패했습니다.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
