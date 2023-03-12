using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using OpenQA.Selenium.DevTools.V108.Debugger;
using System.Security.Cryptography;

namespace Selenium1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int rd = random.Next(0, 3);
            

            ChromeDriver chromeDriver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            chromeDriver.Navigate().GoToUrl("https://quanlydoanvien.doanthanhnien.vn/login");
            var user = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-login/div/div[1]/div[2]/nz-tabset/div/div/div/form/nz-form-item[1]/nz-form-control/div/div/nz-input-group/input"));
            user.SendKeys("ATCL2021");
            var pass = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-login/div/div/div[2]/nz-tabset/div/div/div/form/nz-form-item[2]/nz-form-control/div/div/nz-input-group/input"));            
            pass.SendKeys("Abc@123");
            var login = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-login/div/div/div[2]/nz-tabset/div/div/div/form/div/button/span"));
            login.Click();

            Thread.Sleep(10000);

            chromeDriver.Navigate().GoToUrl("https://quanlydoanvien.doanthanhnien.vn/chuong-trinh-ren-luyen");
            Thread.Sleep(20000);
            

            for (int j=1; j <= 14; j++)
            {
                

                for (int i = 2; i <= 11; i++)
                {
                    try
                    {

                        var selectDaDangKy = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[" + i + "]/td[7]/button"));
                        selectDaDangKy.Click();


                        Thread.Sleep(5000);

                        // select Text
                        var text00 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/thead/tr/th[2]/label/span[1]/input"));
                        text00.Click();
                        Thread.Sleep(1000);

                        var text16 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[8]/td[2]/label/span[1]/input"));
                        text16.Click();

                        var text24 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[13]/td[2]/label/span[1]/input"));
                        text24.Click();

                        var text25 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[14]/td[2]/label/span[1]/input"));
                        text25.Click();

                        var text34 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[19]/td[2]/label/span[1]/input"));
                        text34.Click();

                        var text52 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[27]/td[2]/label/span[1]/input"));
                        text52.Click();

                        var text53 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[28]/td[2]/label/span[1]/input"));
                        text53.Click();

                        var text54 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[29]/td[2]/label/span[1]/input"));
                        text54.Click();
                        // -- Điền vào các trường còn lại 
                        string[] text11 = { "Học tập các Nghị quyết của Đảng, Nghị quyết của cấp ủy, địa phương, đơn vị; Nghị quyết Đại hội đại biểu Đoàn TNCS Hồ Chí Minh lần thứ XII và nghị quyết đại hội đoàn các cấp; các chỉ thị của Ban Bí thư Trung ương Đoàn; các kết luận của Ban Chấp hành, Ban Thường vụ Trung ương Đoàn",
                                        "Tổ chức, tham gia học tập Nghị quyết trực tuyến",
                                        "Tham gia kiểm tra học tập Nghị quyết"};
                        rd = random.Next(0, 3);
                        var use11 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[3]/td[1]/div[2]/nz-input-group/textarea"));
                        use11.Clear();
                        use11.SendKeys("" + text11[rd]);

                        string[] text12 = { "Học tập, chấp hành nghiêm chỉnh và làm theo tư tưởng, đạo đức, phong cách Hồ Chí Minh theo Hướng dẫn số 87-HD/TWĐTN-BTG ngày 28/3/2017" };
                        var use12 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[4]/td[1]/div[3]/nz-input-group/textarea"));
                        use12.Clear();
                        use12.SendKeys("" + text12[0]);

                        string[] text13 = { "Luôn hoàn thành tốt các bài luận do Đoàn đưa ra",
                                        "Có tinh thần hang hái, hăng say trong việc học và hoàn thành các bài luận do Đoàn đưa ra",
                                        "Hoàn thành tốt các bài luận do Đoàn đưa ra",
                                         "Học tập các bài học lý luận chính trị của Đoàn",
                                         "Hoàn thành 4 bài lý luận chính trị dành cho sinh viên"};
                        rd = random.Next(0,5);
                        var use13 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[5]/td[1]/div[2]/nz-input-group/textarea"));
                        use13.Clear();
                        use13.SendKeys("" + text13[rd]);



                        string[] text14 = { "Hay theo dõi các kênh báo đài chính thống do Nhà Nước kiểm duyệt để biết về tình hình trong và ngoài nước",
                                        "Chỉ theo dõi các kênh báo đài thuộc Nhà Nước, tìm hiểu về tình hình thời sự trong nước và cả ngoài nước",
                                        "Hay theo dõi các trang báo có kiểm duyệt, nhằm tránh tin tức sai lệch, chống phá"};
                        rd = random.Next(0, 3);
                        var use14 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[6]/td[1]/div[2]/nz-input-group/textarea"));
                        use14.Clear();
                        use14.SendKeys("" + text14[rd]);




                        string[] text15 = { "Không theo dõi các kênh báo đài chống phá Nhà Nước",
                                        "Thường xuyên chống lại các tin tức sai lệch về chính trị Nhà Nước ta ",
                                        "Không nghe theo hay theo dõi những kênh thông tin chống phá"};
                        rd = random.Next(0, 3);
                        var use15 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[7]/td[1]/div[2]/nz-input-group/textarea"));
                        use15.Clear();
                        use15.SendKeys("" + text15[rd]);




                        string[] text21 = { "Có lối sống giản dị, lành mạnh, không mắc vào các tệ nạn, có các kỹ năng cần thiết như kỹ năng việc nhóm, kỹ năng thu thập và xử lý thông tin",
                                        "Có lối sống tốt đẹp, không va vào các tệ nạn bị nhà nước cấm, có các kỹ năng quan trọng trong xã hội và công việc",
                                        "Sống lành mạnh, không tệ nạn, có sự tích lũy các kỹ năng cần thiết trong tương lai sau này"};
                        rd = random.Next(0, 3);
                        var use21 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[10]/td[1]/div[2]/nz-input-group/textarea"));
                        use21.Clear();
                        use21.SendKeys("" + text21[rd]);




                        string[] text22 = { "Có lối sống yêu thường, quý trọng, tôn trọng người xung quanh",
                                        "Có lối sống quý trọng, yêu thương, đấu tranh có cái đúng và chống lại cái sai, lạc hậu",
                                        "Học tập các lối sống tốt đẹp, tôn trọng, yêu quý mọi người xung quanh, biết đấu tranh cho cái đúng và chống lại cái sai"};
                        rd = random.Next(0, 3);
                        var use22 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[11]/td[1]/div[2]/nz-input-group/textarea"));
                        use22.Clear();
                        use22.SendKeys("" + text22[rd]);



                        string[] text23 = { "Có lối sống trung thực, biết chống lại cái sai",
                                        "Biết tự đánh giá bản thân khi phạm lỗi, trung thực, nói đi đôi với làm",
                                        "Có lối sống thật nhà, tôn trọng mọi người xung quanh"};
                        rd = random.Next(0, 3);
                        var use23 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[12]/td[1]/div[2]/nz-input-group/textarea"));
                        use23.Clear();
                        use23.SendKeys("" + text23[rd]);



                        string[] text31 = { "Luôn hoàn thành tốt các công việc được giao, không bị trễ hay né tránh công việc",
                                        "Có trách nhiệm khi làm việc, có sự tận tụy trong công việc",
                                        "Thường xuyên đảm nhận và luôn hoàn thành tốt các công việc được giao"};

                        rd = random.Next(0, 3);
                        var use31 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[16]/td[1]/div[2]/nz-input-group/textarea"));
                        use31.Clear();
                        use31.SendKeys("" + text31[rd]);



                        string[] text32 = { "Hay đưa ra các giải quyết tốt trong việc làm nhóm, nâng cao hiệu suất công việc",
                                        "Thường xuyên đưa ra các sáng kiến, giải pháp hữu ích trong công việc, luôn tìm kiếm sự nâng cao",
                                        "Biết ứng dụng các kiến thức đã học vào công việc"};
                        rd = random.Next(0, 3);
                        var use32 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[17]/td[1]/div[2]/nz-input-group/textarea"));
                        use32.Clear();
                        use32.SendKeys("" + text32[rd]);



                        string[] text33 = { "Hay đăng ký các khóa học nâng cao tiếng Anh và lập trình",
                                        "Có sự tự học và nâng cao trình độ học vấn bản thân",
                                        "Thường xuyên đăng ký các khóa học nâng cao bên ngoài"};
                        rd = random.Next(0, 3);
                        var use33 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[18]/td[1]/div[2]/nz-input-group/textarea"));
                        use33.Clear();
                        use33.SendKeys("" + text33[rd]);



                        string[] text35 = { "Có sự đăng ký các môn tiếng Anh nâng cao",
                                        "Hay tìm hiểu thêm các khóa học tin học nâng cao",
                                        "Có sự tự học, tự nâng cao bản thân"};
                        rd = random.Next(0, 3);
                        var use35 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[20]/td[1]/div[2]/nz-input-group/textarea"));
                        use35.Clear();
                        use35.SendKeys("" + text35[rd]);



                        string[] text41 = { "Tham gia môn chạy bộ",
                                        "Tham gia môn bóng chuyền",
                                        "Tham gia các môn thể dục như cầu lông, bóng bàn,…"};
                        rd = random.Next(0, 3);
                        var use41 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[22]/td[1]/div[2]/nz-input-group/textarea"));
                        use41.Clear();
                        use41.SendKeys("" + text41[rd]);


                        string[] text42 = { "Thường xuyên tham gia vào các phong trào do lớp hoặc khoa tổ chức",
                                        "Hay tham gia vào các cuộc thi trong và ngoài trường lớp",
                                        "Tích cực tham gia các cuộc thi do trường, hoặc các tổ chức khác tổ chức"};
                        rd = random.Next(0, 3);
                        var use42 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[23]/td[1]/div[2]/nz-input-group/textarea"));
                        use42.Clear();
                        use42.SendKeys("" + text42[rd]);


                        string[] text43 = { "Không sử dụng các chất bị cấm, ít khi uống rượu bia, các chất có hại cho sức khỏe",
                                        "Nói không với các chất nguy hiểm gây nghiện, né tránh các loại thức uống có cồn hoặc gây hại cho sức khỏe",
                                        "Có sự tôn trọng cho sức khỏe bản thân, nói không với chất gây nghiện và ít khi sử dụng rượu bia hoặc thuốc lá"};
                        rd = random.Next(0, 3);
                        var use43 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[24]/td[1]/div[2]/nz-input-group/textarea"));
                        use43.Clear();
                        use43.SendKeys("" + text43[rd]);




                        string[] text51 = { "Thường xuyên tham gia vào các buổi sinh hoạt, đóng các phí đầy đủ",
                                        "Luôn tham gia, đồng thời đóng các phí đúng thời hạn",
                                        "Luôn hăng hái tham gia vào các buổi sinh hoạt, đóng các khoản phí đúng thời hạn"};
                        rd = random.Next(0, 3);
                        var use51 = chromeDriver.FindElement(By.XPath("/html/body/app-root/yum-logged/nz-layout/nz-spin/div/nz-content/div/yum-nvd05-chuong-trinh-ren-luyen/div/div/nz-card/div/nz-spin/div/nz-tabset/div/div/div[1]/yum-dang-ky-ren-luyen/yum-dang-ky-tieu-chi/nz-card/div[2]/nz-table/nz-spin/div/div/nz-table-inner-scroll/div/table/tbody/tr[26]/td[1]/div[2]/nz-input-group/textarea"));
                        use51.Clear();
                        use51.SendKeys("" + text51[rd]);

                        Thread.Sleep(5000);


                        /*Update*/
                        var back = chromeDriver.FindElement(By.CssSelector("body > app-root > yum-logged > nz-layout > nz-spin > div > nz-content > div > yum-nvd05-chuong-trinh-ren-luyen > div > div > nz-card > div > nz-spin > div > nz-tabset > div > div > div.ant-tabs-tabpane.ant-tabs-tabpane-active.ng-star-inserted > yum-dang-ky-ren-luyen > yum-dang-ky-tieu-chi > nz-card > div.ant-card-body > div > nz-space > div > button"));
                        back.Click();
                        Thread.Sleep(8000);
                    }  
                     catch (Exception ex) {
                        Thread.Sleep(5000);
                        Console.WriteLine("Lỗi: " + ex.Message); // in ra thông báo lỗi
                        var screenshot = ((ITakesScreenshot)chromeDriver).GetScreenshot();
                        screenshot.SaveAsFile(@"C:\Users\tuan1\OneDrive\Pictures\vs\screenshot.png", ScreenshotImageFormat.Png);
                        i -= 1;
                        var back1 = chromeDriver.FindElement(By.CssSelector("body > app-root > yum-logged > nz-layout > nz-spin > div > nz-content > div > yum-nvd05-chuong-trinh-ren-luyen > div > div > nz-card > div > nz-spin > div > nz-tabset > div > div > div.ant-tabs-tabpane.ant-tabs-tabpane-active.ng-star-inserted > yum-dang-ky-ren-luyen > yum-dang-ky-tieu-chi > nz-card > div.ant-card-head.ng-star-inserted > div > div.ant-card-extra.ng-star-inserted > a"));
                        back1.Click();
                        Thread.Sleep(5000);
                    }
                    continue;
                }
                Thread.Sleep(5000);

                /*NextPage*/
                var nextPage = chromeDriver.FindElement(By.CssSelector("body > app-root > yum-logged > nz-layout > nz-spin > div > nz-content > div > yum-nvd05-chuong-trinh-ren-luyen > div > div > nz-card > div > nz-spin > div > nz-tabset > div > div > div.ant-tabs-tabpane.ant-tabs-tabpane-active.ng-star-inserted > yum-dang-ky-ren-luyen > nz-table > nz-spin > div > nz-pagination > ul > li.ant-pagination-next.ng-star-inserted > button"));
                nextPage.Click();
                Thread.Sleep(8000);
            }
        }
    }
}
