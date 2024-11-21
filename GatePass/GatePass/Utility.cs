using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace GatePass
{
    // 여러곳에서 사용되는 함수를 이벤트와 연결해서 대기 시켰다가, 필요한 필드에 적용시켜준다.
    internal class Utility
    {

        // AddEmployee 폼의 연락처 필드에서 숫자만 입력받게 만들기
        public static void onlyNumber(KeyPressEventArgs e)
        {
            // 입력된 키가 제어문자 또는 숫자가 아닌 경우
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))  
            {

                e.Handled = true;  // 해당 키 입력을 무시하고 더 이상 다른 이벤트 처리기에게 전달되는 것을 막는다.
            }
        }


        // 고유 ID 번호를 생성하는 메서드
        public static string getUniqueId(string prefix)
        {
            long nano = Stopwatch.GetTimestamp();

            return prefix + nano;
        }


        // 이미지 폴더는 직접 만들어준거
        // 지정된 위치에 매개변수로 전달된 이름을 가진 이미지가 있으면 주소값을 반환
        public static string getImageStorePath(string imageName)
        {

            return Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Images\\" + imageName + ".jpg";

            // Application.StartupPath: 현재 실행 중인 애플리케이션의 시작 경로를 나타내는 문자열
            //                          C:\Users\admin\Desktop\프로젝트2-방문자관리\GatePass\GatePass\bin\Debug

            // Substring(0, (Application.StartupPath.Length - 10)): Application.StartupPath 문자열에서 일부를 잘라내는 것입니다.(마지막 10글자를 제외한 나머지 부분)

            // "\Images\": 경로 문자열의 일부로서, 이미지 파일이 저장될 폴더 지정, 여기서 \\는 역슬래시(\)를 이스케이프 시키기 위한 것입니다.

            //imageName: 이미지 파일의 이름을 나타내는 변수 또는 문자열입니다.

            //".jpg": 이미지 파일의 확장자입니다.


            //            현재 애플리케이션의 시작 경로에서 마지막 10글자를 제외한 부분을 가져와서,
            //그 경로에 "\Images\"라는 하위 폴더를 더한 후,
            //imageName 변수(또는 문자열)을 이미지 파일 이름으로 사용하여 그 뒤에 ".jpg" 확장자를 붙인 경로를 생성합니다.

            //예를 들어, Application.StartupPath가 "C:\MyApp"이고, imageName이 "myimage"라면 결과적인 경로는 "C:\MyApp\Images\myimage.jpg"가 될 것


        }


        // 픽쳐박스와 이미지 이름을 받아 픽쳐박스 이미지란에 이미지를 세팅한다.
        public static void setImageInpictureBox(PictureBox pictureBoxProfile, string visitorId)
        {
            string path = getImageStorePath(visitorId);     // visitorid와 이미지 파일 이름을 같게 하여 path 주소값에 이미지를 저장한다.

            if (pictureBoxProfile.Image != null)
            {
                pictureBoxProfile.Image.Dispose();
                pictureBoxProfile.Image = null;
            }
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.Image = Image.FromFile(path);


        }


    }
}
