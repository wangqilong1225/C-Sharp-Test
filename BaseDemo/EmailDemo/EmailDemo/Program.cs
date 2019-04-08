using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string mailTo = "wangqilong**************";  //接收方
            string mailSubject = "Send Email Test";      //邮件主题   
            string mailContent = "<html><body><div><font color='blue'>This is a email for Send Email Test</font></div></body></html>";  //邮件内容
            SendEmail(mailTo, mailSubject, mailContent);
        }

        public static bool SendEmail(string mailTo, string mailSubject, string mailContent)
        {
            //设置发送方的邮件信息,使用最常见的qq邮箱
            string smtpServer = "smtp.qq.com";         //SMTP服务器
            string mailFrom = "664660754@qq.com";      //登陆用户名
            string userPassword = "****************";  //SMTP授权码

            //邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;  //邮件发送方式
            smtpClient.Host = smtpServer;                            //SMTP服务器
            smtpClient.Port = 587;                                   //qq邮箱SMTP发送端口，可以不填           
            smtpClient.EnableSsl = true;                             //qq邮箱SMTP SSL加密，可以不填 
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword); //用户名和密码

            //发送邮件设置       
            MailMessage mailMessage = new MailMessage(mailFrom, mailTo);    //发送人和收件人
            mailMessage.Subject = mailSubject;                              //邮件主题
            mailMessage.Body = mailContent;                                 //邮件内容
            mailMessage.BodyEncoding = Encoding.UTF8;                       //邮件正文编码
            mailMessage.IsBodyHtml = true;                                  //设置为HTML格式
            mailMessage.Priority = MailPriority.Low;                        //优先级，可不填

            try
            {
                smtpClient.Send(mailMessage);   //发送邮件
                return true;
            }
            catch (SmtpException e)
            {
                return false;
            }
        }
    }
}
