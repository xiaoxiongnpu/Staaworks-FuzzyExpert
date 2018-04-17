﻿using Staaworks.BankExpert.Core.Repositories;
using Staaworks.BankExpert.Shared.Models;
using Staaworks.BankExpert.WinForms.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Staaworks.BankExpert.WinForms
{
    public class QuestionAndAnswerViewDataHolder : IViewDataHolder
    {
        public Control ViewDataControl
        {
            get => QuestionView;
            set => QuestionView = (value as QuestionView);
        }

        public Dictionary<Question, Option> Questions { get; set; }
        public QuestionView QuestionView { get; set; }
        public Context CurrentContext { get; set; }
        private IQuestionOptionReciever Reciever { get; }

        public QuestionAndAnswerViewDataHolder(IQuestionOptionReciever reciever)
        {
            ViewDataControl = QuestionView;
            Reciever = reciever;
        }


        public void PopulateControl(params object[] parameters)
        {
            var contextName = parameters.Any() ? parameters[0].ToString() : "RootContext";
            QuestionView = new QuestionView(Reciever);
            CurrentContext = QuestionRepository.LoadContext(contextName);
            UpdateQuestionView();
        }


        public void UpdateQuestionView()
        {
            Questions = CurrentContext.Questions.ToDictionary<Question, Question, Option>(q => q, q => null);
            LoadNextQuestion();
            Reciever.AddControl(QuestionView);
        }






        public void LoadNextQuestion()
        {
            QuestionView.SetCurrentQuestion(Questions.First(p => p.Value == null).Key, Questions.Count(p => p.Value == null) <= 1);
        }
    }
}