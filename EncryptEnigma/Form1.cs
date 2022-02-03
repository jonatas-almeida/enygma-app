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
using System.Security.Cryptography;

namespace EncryptEnigma
{
    public partial class TelaPrincipal : Form
    {

        CspParameters cspp = new CspParameters();
        RSACryptoServiceProvider rsa;

        //Declarando variáveis de onde serão salvos os
        //arquivos criptografados e descriptografados
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        const string KeysFolder = @"c:\Keys\";
        const string SrcFolder = @"c:\docs\";

        //Arquivo da chave pública
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        //Nome do container da chave privada/publica
        const string keyName = "BubbleDevTeam";

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            
        }

        //Método EncryptFile
        private void EncryptFile(string inFile)
        {
            RijndaelManaged rjnd = new RijndaelManaged();
            rjnd.KeySize = 256;
            rjnd.BlockSize = 256;
            rjnd.Mode = CipherMode.CBC;
            ICryptoTransform transform = rjnd.CreateEncryptor();

            byte[] keyEncrypted = rsa.Encrypt(rjnd.Key, false);
            byte[] Lenk = new byte[4];
            byte[] LenIV = new byte[4];

            // Verifica se o diretório existe, caso não exista ele cria
            if (!Directory.Exists(EncrFolder))
            {
                Directory.CreateDirectory(EncrFolder);
            }

            int lKey = keyEncrypted.Length;
            Lenk = BitConverter.GetBytes(lKey);
            int lIV = rjnd.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            //FileStream
            int startFileName = inFile.LastIndexOf("\\") + 1;
            //Muda a extensão do arquivo para .enc
            string outFile = EncrFolder + inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";


            using (FileStream outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(Lenk, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(rjnd.IV, 0, lIV);

                //Escrevendo o texto cifrado usando o CryptoStream para criptografar
                using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    //Criptografando uma "crifra" por vez
                    //economiza mais memória e acomoda
                    //arquivos maiores

                    int count = 0;
                    int offset = 0;

                    //BlockSizeBytes podem ter tamanhos arbitrários
                    int blockSizeBytes = rjnd.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        }
                        while (count > 0);

                        inFs.Close();
                    }
                    outStreamEncrypted.FlushFinalBlock();
                    outStreamEncrypted.Close();
                }
                outFs.Close();

                MessageBox.Show("Arquivo criptografado com sucesso!");
            }
        }

        private void ButtonEncryptFile_Click(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Chave não gerada!");
            }

            else
            {
                openFileDialog1.InitialDirectory = SrcFolder;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog1.FileName;
                    if (fName != null)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        //Passa o nome do arquivo sem o caminho
                        string name = fInfo.FullName;
                        EncryptFile(name);
                    }
                }
            }
        }

        //Método de Descriptografar
        private void DecryptFile(string inFile)
        {
            RijndaelManaged rjnd = new RijndaelManaged();
            rjnd.KeySize = 256;
            rjnd.BlockSize = 256;
            rjnd.Mode = CipherMode.CBC;

            byte[] Lenk = new byte[4];
            byte[] LenIV = new byte[4];

            //Variável definida como null
            //para poder atribuir um valor a ela
            //nas estruturas de decisão
            string outFile = null;

            //USAR CHECKBOX PARA IDENTIFICAR O TIPO DE ARQUIVO
            if (checkBoxPdf.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".pdf";
            }
            else if (checkBoxJpg.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".jpg";
            }
            else if (checkBoxJpeg.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".jpeg";
            }
            else if (checkBoxDocx.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".docx";
            }
            else if (checkBoxPng.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".png";
            }
            else if (checkBoxPsd.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".psd";
            }
            else if (checkBoxRtf.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".rtf";
            }
            else if (checkBoxXls.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".xls";
            }
            else if (checkBoxPptx.Checked == true)
            {
                outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".pptx";
            }

            //Caso nenhuma opção seja selecionada
            else
            {
                MessageBox.Show("Selecione o tipo de arquivo a ser descriptografado e em seguida tente novamente!");
                return;
            }



            //Usa o FileStream para ler o arquivo criptografado
            //e salvar o mesmo

            using (FileStream inFs = new FileStream(EncrFolder + inFile, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(Lenk, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                //Converte os lengths para valores inteiros
                int lenK = BitConverter.ToInt32(Lenk, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                //Determina o posição inicial da cifra e
                //o seu comprimento
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                //Cria arrays de bytes para a
                //chave de criptografia Rijndael, a IV e o texto cifrado
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                //Extrai a chave e IV
                //começando do índice 8
                //depois de ler os valores de comprimento
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);
                Directory.CreateDirectory(DecrFolder);

                //Usa o RSACryptoServiceProvider
                //para Descriptografar a chave
                byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                //Descriptografa a chave
                ICryptoTransform transform = rjnd.CreateDecryptor(KeyDecrypted, IV);

                //Descriptografa o texto cifrado
                //usando o FileStream

                using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = rjnd.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        }

                        while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                        outStreamDecrypted.Close();
                    }
                    outFs.Close();
                }
                inFs.Close();

                MessageBox.Show("Arquivo descriptografado com sucesso!");
            }
        }

        //GERAR CHAVE
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Chave não gerada!");
            }
            else
            {
                //Exibe uma caixa de diálogo para selecionar o arquivo criptografado
                
                openFileDialog2.InitialDirectory = EncrFolder;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog2.FileName;
                    if (fName != null)
                    {
                        FileInfo fi = new FileInfo(fName);
                        string name = fi.Name;
                        DecryptFile(name);
                    }
                }
            }
        }

        //EXPORTAR A CHAVE PÚBLICA
        private async Task Button2_Click(object sender, EventArgs e)
        {
            
        }

        //IMPORTAR A CHAVE PRIVADA
        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------

        //PDF
        private void CheckBoxPdf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPdf.Checked == true)
            {
                checkBoxRtf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxDocx.Enabled = false;
                checkBoxXls.Enabled = false;
            }
            else
            {
                checkBoxRtf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }
        //----------------------------------------------------------------------------------

        //RTF
        private void CheckBoxRtf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRtf.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxDocx.Enabled = false;
                checkBoxXls.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }
        //------------------------------------------------------------------------------------

        //DOCX
        private void CheckBoxDocx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDocx.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxXls.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }
        //-----------------------------------------------------------------------------------

        //PPTX
        private void CheckBoxPptx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPptx.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxDocx.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxXls.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }
        //----------------------------------------------------------------------------------

        //XLS
        private void CheckBoxXls_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXls.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxDocx.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxDocx.Enabled = true;
            }
        }
        //----------------------------------------------------------------------------------

        //JPG
        private void CheckBoxJpg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJpg.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxDocx.Enabled = false;
                checkBoxXls.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }
        //-------------------------------------------------------------------------------------------

        //PNG
        private void CheckBoxPng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPng.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxXls.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxDocx.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }

        //JPEG
        private void CheckBoxJpeg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJpeg.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxXls.Enabled = false;
                checkBoxPsd.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxDocx.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }

        //PSD
        private void CheckBoxPsd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPsd.Checked == true)
            {
                checkBoxPdf.Enabled = false;
                checkBoxJpg.Enabled = false;
                checkBoxJpeg.Enabled = false;
                checkBoxPng.Enabled = false;
                checkBoxXls.Enabled = false;
                checkBoxRtf.Enabled = false;
                checkBoxPptx.Enabled = false;
                checkBoxDocx.Enabled = false;
            }
            else
            {
                checkBoxPdf.Enabled = true;
                checkBoxJpg.Enabled = true;
                checkBoxJpeg.Enabled = true;
                checkBoxPng.Enabled = true;
                checkBoxPptx.Enabled = true;
                checkBoxPsd.Enabled = true;
                checkBoxRtf.Enabled = true;
                checkBoxDocx.Enabled = true;
                checkBoxXls.Enabled = true;
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ButtonGerarKey_Click(object sender, EventArgs e)
        {
            //Guardar uma chave no container da chave
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly == true)
            {
                label1.Text = "KEY PÚBLICA GERADA COM SUCESSO";
                label2.Text = "A kKey está pronta para a exportação";
            }

            else
            {
                label1.Text = "KEY COMPLETA GERADA COM SUCESSO";
                label2.Text = "A Key está pronta para a exportação";
            }
        }

        // Exporta a chave pública para ser utilizada posteriormente
        private async void Button2_Click_1(object sender, EventArgs e)
        {
            if (rsa != null)
            {
                // Verifica se o diretório existe, se não existir ele cria
                if (!Directory.Exists(KeysFolder))
                {
                    Directory.CreateDirectory(KeysFolder);
                }

                // Abre a janela para selecionar onde o arquivo será salvo, como padrão ele abre o diretório 'Keys'
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Text |* .txt",
                    InitialDirectory = KeysFolder,
                    FileName = "PublicKey" + DateTime.Now.Millisecond.ToString() + ".txt",
                })

                // Caso o botão clicado seja o de 'OK' ele salva o arquivo, se for o 'Cancelar' ele fecha o Dialog
                if (sfd.ShowDialog() ==  DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                       await tw.WriteLineAsync(rsa.ToXmlString(true)); // Escreve no arquivo
                    }

                       MessageBox.Show("Chave pública exportada com sucesso");
                    }

                }
                else
                {
                    MessageBox.Show("Gere a chave pública antes");
                }
        }

        // Importar chave pública (Precisa de melhoria)
        // ---------------------------------------------
        // MELHORIA - Necessita que o usuário escolha uma chave que já foi exportada, e não uma pré-definida no código
        private async void Button3_Click_2(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(PubKeyFile);
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);

            string keytxt = sr.ReadToEnd();
            rsa.FromXmlString(keytxt);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly == true)
            {
                label1.Text = "Key: " + cspp.KeyContainerName + " - Public Only";
                label2.Visible = false;
            }
            else
            {
                label1.Text = "Key: " + cspp.KeyContainerName + " - Full Key";
                label2.Visible = false;
            }
            sr.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TelaTutorial telaTutorial = new TelaTutorial();
            telaTutorial.Show();
        }
    }
}
