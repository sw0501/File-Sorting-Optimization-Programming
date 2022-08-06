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
using IWshRuntimeLibrary;

namespace File_Sorting_Optimization
{

    public partial class Form1 : Form
    {
        //Form 시작할 때 실행
        public Form1()
        {
            
            InitializeComponent();

            //Winform Form 제목 변경
            this.Text = "파일 정렬 최적화 프로그램";

            //ListBox에 정렬기준 추가
            CKList_Sort.Items.Add("파일명");
            CKList_Sort.Items.Add("파일크기");
            CKList_Sort.Items.Add("수정날짜");
            CKList_Sort.Items.Add("확장자");
            
            //오름차순 체크 상태로 변경
            checkBox_asc.Checked = true;

            //즐겨찾기 폴더가 없는 경우 생성
            string folderPath = "C:\\정렬된즐겨찾기";
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false)
            {
                di.Create();
                folderPath += "\\미분류";
                DirectoryInfo temp = new DirectoryInfo(folderPath);
                temp.Create();
            }

            //즐겨찾기 폴더 내 하위 디렉토리 리스트에 아이템으로 저장
            DirectoryInfo[] category = di.GetDirectories();

            foreach (DirectoryInfo temp in category)
            {
                listBox_Category.Items.Add(temp.Name);
                comboBox_category.Items.Add(temp.Name);
            }
        }

        //폴더 선택 버튼
        private void Button_Select_Directory_Click(object sender, EventArgs e)
        {
            //공백일 경우 와일드카드 * 로 변경
            if (textBox_Filter_Filename.Text.ToString() == "") textBox_Filter_Filename.Text = "*";
            if (textBox_Filter_extension.Text.ToString() == "") textBox_Filter_extension.Text = "*";
            //제목이름 + 확장자 로 파일 검색

            string filter = textBox_Filter_Filename.Text.ToString() + "." + textBox_Filter_extension.Text.ToString();
            string file = "";
            string[] filenames = null;

            //파일탐색기 UI 열기
            FolderBrowserDialog OFD = new FolderBrowserDialog();
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    //file에 선택한 디렉토리 이름 저장
                    file = OFD.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("폴더를 선택해주세요");
                //MessageBox.Show(ex.Message);
            }
         
            try
            {
                try
                {
                    //디렉토리 내 모든 파일 검색하여 저장
                    filenames = Directory.GetFiles(file, filter, SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("폴더를 선택해주세요");
                    //MessageBox.Show(ex.ToString());
                    return; 
                }

                //우선순위에 따라 정렬 (compare_File 함수 이용)
                for(int i = 0; i < filenames.Length-1; i++)
                {
                    //정렬 우선순위가 높다면 서로 교환 (오름차순)
                    if (compare_File(filenames[i], filenames[i + 1], 0) > 0 && checkBox_asc.Checked)
                    {
                        string temp = filenames[i];
                        filenames[i] = filenames[i + 1];
                        filenames[i + 1] = temp;
                    }
                    //정렬 우선순위가 높다면 서로 교환 (내림차순)
                    else if (compare_File(filenames[i], filenames[i + 1], 0) < 0 && !checkBox_asc.Checked)
                    {
                        string temp = filenames[i];
                        filenames[i] = filenames[i + 1];
                        filenames[i + 1] = temp;
                    }
                    //우선순위가 같다면 순서 바꾸지 않음
                    else
                    {
                        continue;
                    }
                }

                //기존에 ListBox와 ComboBox에 들어있는 파일들 제거
                listBox_Sort_result.Items.Clear();
                comboBox_file.Items.Clear();

                //ListBox와 ComboBox에 정렬된 파일 순서대로 저장
                for (int i = 0; i < filenames.Length; i++)
                {
                    listBox_Sort_result.Items.Add(filenames[i].ToString());
                    comboBox_file.Items.Add(filenames[i].ToString());
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //사용자 정의 정렬 기준 
        private void CKList_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택한 item이 체크 됐다면
            if (CKList_Sort.GetItemChecked(CKList_Sort.SelectedIndex))
            {
                //listBox에 포함되어있지 않은 item이라면 추가
                if (!listBox_sort.Items.Contains(CKList_Sort.SelectedItem.ToString()))
                {
                    listBox_sort.Items.Add(CKList_Sort.SelectedItem);
                }
                
            }
            //선택한 item이 체크 되어있지 않다면
            else
            {
                //listBox에 포함되어있다면 list에서 item 제거
                if (listBox_sort.Items.Contains(CKList_Sort.SelectedItem.ToString()))
                {
                    listBox_sort.Items.Remove(CKList_Sort.SelectedItem);
                }
            }
        }
        
        //정렬 함수
        private int compare_File(string file1, string file2,int count)
        {
            //모든 정렬 기준을 비교했다면 SWAP X
            if (count == listBox_sort.Items.Count) return 0;

            //파일의 정보 저장
            var info1 = new FileInfo(file1);
            var info2 = new FileInfo(file2);

            //비교 타입 문자열 저장
            string type = listBox_sort.Items[count].ToString();

            //파일명을 선택한 경우
            if (type == "파일명")
            {
                //파일이름이 같은 경우, 다음에 선택된 정렬기준으로 비교
                if (info1.Name.ToString().Split('.')[0].CompareTo(info2.Name.ToString().Split('.')[0]) == 0)
                {
                    return compare_File(file1, file2, count + 1);
                }
                //다른 경우 비교결과 리턴
                else
                {
                    return info1.Name.ToString().Split('.')[0].CompareTo(info2.Name.ToString().Split('.')[0]);
                }
            }
            //파일크기를 선택한 경우
            else if (type == "파일크기")
            {
                //length에다 파일의 길이 저장
                long length1 = new System.IO.FileInfo(file1).Length;
                long length2 = new System.IO.FileInfo(file2).Length;
                
                //파일크기가 같은 경우 다음에 선택된 정렬기준으로 비교
                if (length1 == length2)
                {
                    return compare_File(file1, file2, count + 1);
                }
                //다른 경우 비교결과 리턴
                else
                {
                    return length1.CompareTo(length2);
                }
                
            }
            //수정날짜를 선택한 경우
            else if (type == "수정날짜")
            {
                //수정날자가 같은경우 다음에 선택된 정렬 기준으로 비교
                if (info1.LastWriteTime.CompareTo(info2.LastWriteTime)==0)
                {
                    return compare_File(file1, file2, count + 1);
                }
                //다른 경우 비교결과 리턴
                else
                {
                    return info1.LastWriteTime.CompareTo(info2.LastWriteTime);
                }
            }
            //확장자를 선택한 경우
            else if (type == "확장자")
            {
                //확장자가 같은 경우 다음에 선택된 정렬 기준으로 비교
                if (info1.ToString().Split('.')[1].CompareTo(info2.ToString().Split('.')[1]) == 0)
                {
                    return compare_File(file1, file2, count + 1);
                }
                //다른 경우 비교결과 리턴
                else
                {
                    return info1.ToString().Split('.')[1].CompareTo(info2.ToString().Split('.')[1]);
                }
            }
            //정렬 우선순위가 없는 경우 0리턴
            else
            {
                return 0;
            }
        }

        //파일 선택 Method
        private void listBox_Sort_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            //정렬된 파일을 선택하지않고 ListBox를 클릭한 경우
            if(listBox_Sort_result.SelectedItem is null)
            {
                return;
            }

            try
            {
                //리스트에서 선택한 아이템의 파일 정보를 info에 저장
                var info = new FileInfo(listBox_Sort_result.SelectedItem.ToString());
                //dir에 해당 파일의 디렉토리 주소를 저장
                string dir = $@"{info.DirectoryName}";
                //해당 위치로 파일탐색기 열기
                System.Diagnostics.Process.Start("explorer.exe", dir);

                //카테고리 선택 후에 선택된 파일들 체킹 해제
                listBox_Sort_result.SelectedItems.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //즐겨찾기내 카테고리 폴더 추가
        private void button_add_category_Click(object sender, EventArgs e)
        {
            //추가할 카테고리 이름 저장
            string folderPath = category.Text;
            DirectoryInfo di = new DirectoryInfo("C:\\정렬된즐겨찾기\\"+folderPath);
            //해당 카테고리가 존재하지 않는다면
            if (di.Exists == false)
            {
                //카테고리 폴더 추가 및 리스트와 콤보박스에 아이템 추가
                di.Create();
                listBox_Category.Items.Add(category.Text);
                comboBox_category.Items.Add(category.Text);
            }

            //이미 있다면 에러메세지 호출
            else
            {
                MessageBox.Show("이미 존재하는 카테고리입니다.");
            }

        }

        //파일 카테고리 지정
        private void button_add_file_Click(object sender, EventArgs e)
        {
            //파일을 선택하지 않고 선택 버튼을 누른 경우 에레메세지 호출
            if (comboBox_file.SelectedItem == null)
            {
                MessageBox.Show("파일을 선택해주세요.");
            }
            else
            {

                string folderPath = "C:\\정렬된즐겨찾기\\" + comboBox_category.SelectedItem.ToString();
                //Linkstr에 바로가기 파일 이름 저장
                string name = Path.GetFileName(comboBox_file.SelectedItem.ToString());
                string Linkstr = $"{name} 바로가기.lnk";
                string LinkFileName = folderPath.ToString() + $@"\{Linkstr}";
                FileInfo LinkFile = new FileInfo(LinkFileName);

                //바로가기 파일이 이미 있다면 건너뜀
                if (LinkFile.Exists)
                {
                    
                }

                else
                {
                    //바로가기 생성
                    WshShell wsh = new WshShell();
                    IWshShortcut Link = wsh.CreateShortcut(LinkFile.FullName);

                    //원본파일 경로
                    StringBuilder SB = new StringBuilder();

                    //바로가기 저장
                    SB.Append(@comboBox_file.SelectedItem.ToString());
                    Link.TargetPath = SB.ToString();
                    Link.Save();
                }

                listBox_Sort_result.Items.Remove(comboBox_file.SelectedItem);
                comboBox_file.Items.Remove(comboBox_file.SelectedItem);
            }
        }

        //카테고리 ITEM 클릭 이벤트
        private void listBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //빈 아이템을 선택시 예외처리
            if (listBox_Category.SelectedItem == null)
            {
                return;
            }
            try
            {
                //카테고리 클릭시 해당 카테고리의 디렉토리 창 열기
                System.Diagnostics.Process.Start("explorer.exe", "C:\\정렬된즐겨찾기\\" + listBox_Category.SelectedItem.ToString());
                listBox_Category.SelectedItems.Clear(); //카테고리 선택 후에 선택된 파일들 초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //윈폼 종료시 이벤트 설정
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //사용자에게 종료 여부 확인
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //즐겨찾기 내에서 남아있는 모든 파일을 미분류로 옮겨줌
                for (int i = 0; i < listBox_Sort_result.Items.Count; i++)
                {
                    string folderPath = "C:\\정렬된즐겨찾기\\미분류";
                    //Linkstr에 바로가기 파일 이름 저장
                    string name = Path.GetFileName(listBox_Sort_result.Items[i].ToString());
                    string Linkstr = $"{name} 바로가기.lnk";
                    string LinkFileName = folderPath.ToString() + $@"\{Linkstr}";
                    FileInfo LinkFile = new FileInfo(LinkFileName);

                    //바로가기 파일이 이미 있다면 건너뜀
                    if (LinkFile.Exists)
                    {
                        continue;
                    }

                    else
                    {
                        //바로가기 생성
                        WshShell wsh = new WshShell();
                        IWshShortcut Link = wsh.CreateShortcut(LinkFile.FullName);

                        //원본파일 경로
                        StringBuilder SB = new StringBuilder();

                        //바로가기 저장
                        SB.Append(@listBox_Sort_result.Items[i].ToString());
                        Link.TargetPath = SB.ToString();
                        Link.Save();
                    }
                }
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        //프로그램 종료 버튼
        private void button_Exit_Click(object sender, EventArgs e)
        {

            //FormClosing() 실행
            Application.Exit();

        }

        private void button_Select_Category_Click(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedItem == null)
            {
                MessageBox.Show("카테고리를 선택해주세요.");
            }
            else
            {
                listBox_Category_File.Items.Clear();
                string[] filenames;

                string file = "C:\\정렬된즐겨찾기";
                if (comboBox_category.SelectedItem.ToString() != null)
                {
                    file += "\\" + comboBox_category.SelectedItem.ToString();
                }

                filenames = Directory.GetFiles(file, "*.*", SearchOption.TopDirectoryOnly);

                foreach (string filename in filenames)
                {
                    FileInfo fi = new FileInfo(filename);
                    listBox_Category_File.Items.Add(fi.Name);
                }
            }
        }
    }
}
