﻿using baitap5_64131055.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap4_64131055.Controllers
{
    public class MailInfor_64131055Controller : Controller
    {
        // GET: MailInfor_64131055
        public ActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMail(MailInfo_64131055 model)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress(model.From);
                mail.To.Add(model.To);
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                mail.IsBodyHtml = true;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                TempData["SuccessMessage"] = "Email đã được gửi thành công!";
                return RedirectToAction("Mail");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error: " + ex.Message;
                return View(model);
            }
        }

        public ActionResult Mail()
        {
            return View();
        }
    }
}
