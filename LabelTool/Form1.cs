using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
/*
 * Author: Furkan Güvenç
 * Date: 04.10.2019
 */

namespace LabelTool
{

    public partial class MainForm : Form
    {
        Config config = new Config();
        public string[] pictures;
        public int pic_index = 0;
        public int pic_score = -1; // not scored

        public MainForm()
        {
            InitializeComponent();
            config.read_config();
            if (config.ImageDir != null && config.ImageExtension != null) read_pictures();
            if (!Directory.Exists(annotation_file_dir_path))
            {
                Directory.CreateDirectory(annotation_file_dir_path);
            }

        }

        public static string config_file_path = "config.ini";
        public static string config_file_dir_path = Directory.GetCurrentDirectory() + "\\" + config_file_path;

        public static string annotation_file_dir_path = Directory.GetCurrentDirectory() + "\\" + "Annotations" + "\\";


        class Config
        {
            public string ImageExtension { get; set; }
            public string ImageDir { get; set; }

            public void read_config()
            {

                if (File.Exists(config_file_dir_path))
                {
                    var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(config_file_dir_path));
                    ImageExtension = config.ImageExtension;
                    ImageDir = config.ImageDir;
                }
            }

        }

        private string get_image_id(string image_path)
        {
            string[] splitted_path = image_path.Split('\\', '.');
            string image_id = splitted_path[splitted_path.Length - 2];
            return image_id;
        }

        private void write_annotation(string image_id)
        {
            if (pic_score != -1)
            {
                string path = annotation_file_dir_path + image_id + ".txt";
                File.WriteAllText(path, pic_score.ToString());
            }

        }

        private string read_annotation(string image_id)
        {
            string path = annotation_file_dir_path + image_id + ".txt";
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                return text;
            }
            return String.Empty;
        }

        private void read_pictures()
        {
            pictures = Directory.GetFiles(config.ImageDir, "*." + config.ImageExtension);
            if (pictures.Length > 0)
            {
                pic_main.ImageLocation = pictures[0];
                pb_image_progess.Maximum = pictures.Length - 1;
                pic_prev.ImageLocation = pictures[pictures.Length - 1];

                if (pictures.Length > 1) pic_next.ImageLocation = pictures[1];

            }
        }

        private void write_config()
        {
            File.WriteAllText(config_file_dir_path, JsonConvert.SerializeObject(config));
        }

        private void go_image(string desen_id)
        {

            for (int i = 0; i < pictures.Length; i++)
            {
                string image_id = get_image_id(pictures[i]);
                if (image_id == desen_id)
                {
                    pic_main.ImageLocation = pictures[i];
                    if (i == 0)
                    {
                        pic_prev.ImageLocation = pictures[pictures.Length - 1];
                        pic_next.ImageLocation = pictures[1];
                    }
                    else if (i == pictures.Length - 1)
                    {
                        pic_prev.ImageLocation = pictures[i - 1];
                        pic_next.ImageLocation = pictures[0];
                    }
                    else
                    {
                        pic_prev.ImageLocation = pictures[i - 1];
                        pic_next.ImageLocation = pictures[i + 1];
                    }
                    pic_index = i;
                    // Read score
                    desen_id = get_image_id(pictures[pic_index]);
                    txt_image_id.Text = desen_id;
                    txt_score.Text = read_annotation(desen_id);

                    break;
                }
            }
        }

        private void btn_image_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog image_dir = new FolderBrowserDialog();
            image_dir.Description = "Choose Image Folder!";
            if (image_dir.ShowDialog() == DialogResult.OK)
            {
                pic_index = 0;
                config.ImageDir = image_dir.SelectedPath;
                write_config();
                read_pictures();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_index = 0;
            config.ImageExtension = lb_image_ext.SelectedItem.ToString();
            write_config();
            read_pictures();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (pictures == null || pictures.Length == 0)
            {
                MessageBox.Show("No Image");
            }
            else
            {   // Save score
                string desen_id = get_image_id(pictures[pic_index]);
                write_annotation(desen_id);
                pic_score = -1;

                // Change pictures
                if (pic_index == pictures.Length - 1) // prev: last, main: 0, next:1
                {
                    pic_prev.ImageLocation = pictures[pic_index];
                    pic_index = 0;
                    pic_next.ImageLocation = pictures[pic_index + 1];
                }
                else if (pic_index == pictures.Length - 2) // prev: last - 1, main: last, next:0
                {
                    pic_prev.ImageLocation = pictures[pic_index];
                    pic_index++;
                    pic_next.ImageLocation = pictures[0];
                }
                else // normal
                {
                    pic_prev.ImageLocation = pictures[pic_index];
                    pic_index++;
                    pic_next.ImageLocation = pictures[pic_index + 1];
                }
                pic_main.ImageLocation = pictures[pic_index];
                pb_image_progess.Value = pic_index;

                // Read score
                desen_id = get_image_id(pictures[pic_index]);
                txt_image_id.Text = desen_id;
                txt_score.Text = read_annotation(desen_id);
            }


        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (pictures == null || pictures.Length == 0)
            {
                MessageBox.Show("No Image");
            }
            else
            {
                // Save score
                string desen_id = get_image_id(pictures[pic_index]);
                write_annotation(desen_id);
                pic_score = -1;

                // Change pictures
                if (pic_index == 1) // prev: last, main: 0, next:1
                {
                    pic_index--;
                    pic_prev.ImageLocation = pictures[pictures.Length - 1];
                    pic_next.ImageLocation = pictures[pic_index + 1];
                }
                else if (pic_index == 0) // prev: last - 1, main: last, next:0
                {
                    pic_index = pictures.Length - 1;
                    pic_prev.ImageLocation = pictures[pic_index - 1];
                    pic_next.ImageLocation = pictures[0];
                }
                else // normal
                {
                    pic_index--;
                    pic_prev.ImageLocation = pictures[pic_index - 1];
                    pic_next.ImageLocation = pictures[pic_index + 1];
                }
                pic_main.ImageLocation = pictures[pic_index];
                pb_image_progess.Value = pic_index;

                // Read score
                desen_id = get_image_id(pictures[pic_index]);
                txt_image_id.Text = desen_id;
                txt_score.Text = read_annotation(desen_id);


            }

        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            pic_score = 9;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            pic_score = 8;
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            pic_score = 7;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pic_score = 6;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            pic_score = 5;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            pic_score = 4;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            pic_score = 3;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            pic_score = 2;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            pic_score = 1;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            pic_score = 0;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 58 && e.KeyValue > 47)
            {
                pic_score = e.KeyValue - 48;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                btn_prev_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                btn_save_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                btn_next_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                go_image(txt_image_id.Text);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pictures == null || pictures.Length == 0)
            {
                MessageBox.Show("No Image");
            }
            else
            {
                // Save score
                string desen_id = get_image_id(pictures[pic_index]);
                write_annotation(desen_id);
                pic_score = -1;

                // Read score
                desen_id = get_image_id(pictures[pic_index]);
                txt_image_id.Text = desen_id;
                txt_score.Text = read_annotation(desen_id);
            }
            
        }
    }
}
