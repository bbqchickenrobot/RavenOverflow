﻿using RavenOverflow.Web.Models;
using RavenOverflow.Web.Models.Authentication;

namespace RavenOverflow.Web.Areas.Question.Models
{
    public class QuestionViewModel : _LayoutViewModel
    {
        public QuestionViewModel(ICustomIdentity customIdentity) : base(customIdentity)
        {
        }

        public string Subject { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
    }
}