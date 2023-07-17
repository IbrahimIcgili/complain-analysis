using ComplainAnalysis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplainAnalysis
{
    public partial class Form1 : Form
    {
        private readonly Context _context;
        private readonly Service service;
        public static ComparisonResult _result;

        public Form1()
        {
            InitializeComponent();
            _context = new Context();
            service = new Service();
        }

        static readonly public Dictionary<Fields, string> FieldSource = new Dictionary<Fields, string>()
        {
            { Fields.COMPANY, "Company" },
            { Fields.COMPLAINT_ID, "Complaint Id" },
            { Fields.ISSUE, "Issue" },
            { Fields.PRODUCT, "Product" },
            { Fields.STATE, "State" },
            { Fields.ZIP_CODE, "Zip Code" },
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            compareFieldCmb.DataSource = new BindingSource(FieldSource, null);
            compareFieldCmb.DisplayMember = "Value";
            compareFieldCmb.ValueMember = "Key";

            valueFieldCmb.DataSource = new BindingSource(FieldSource, null);
            valueFieldCmb.DisplayMember = "Value";
            valueFieldCmb.ValueMember = "Key";

            threadListGV.ReadOnly = true;

            matchListGV.ReadOnly = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var req = new ComparisonRequest();

            threadPanel.Visible = false;
            matchPanel.Visible = false;

            if (int.TryParse(textBox2.Text, out int intValue) && intValue > 0 )
            {
                req.ComplaintId = intValue;
            }

            if (int.TryParse(thresholdRatioTxt.Text, out int ratioValue))
            {
                req.ThresholdRatio = ratioValue;
            }
            else
            {
                MessageBox.Show("Hatalı benzerlik oranı.");
                return;
            }

            if (int.TryParse(textBox1.Text, out int threadValue) && threadValue > 0)
            {
                req.ThreadCount = threadValue;
            }
            else
            {
                MessageBox.Show("Hatalı thread sayısı.");
                return;
            }

            if (int.TryParse(dataCountTxt.Text, out int countVal) && countVal > 0)
            {
                req.DataCount = countVal;
            }
            else
            {
                req.DataCount = 100000;
            }

            req.IsSameProducts = sameProductsCb.Checked;
            req.CompareField = (Fields)compareFieldCmb.SelectedValue;
            req.ValueField = (Fields)valueFieldCmb.SelectedValue;

            _result = new ComparisonResult()
            {
                MatchList = new(),
                ThreadList = new(),
            };

            await GetComplaintsByReq(req);

            if(req.ComplaintId != null)
            {
                _result.MatchList = _result.MatchList.Where(x => x.MainId == req.ComplaintId).ToList();
            }

            threadListGV.DataSource = _result.ThreadList;
            matchListGV.DataSource = _result.MatchList.OrderByDescending(x => x.Rate).ToList();
            matchPanel.Visible = true;
            threadPanel.Visible = true;
        }

        private async Task GetComplaintsByReq(ComparisonRequest requestModel)
        {
            var datas = new List<ComparisonModel>();

            switch (requestModel.CompareField)
            {
                case Fields.PRODUCT:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.Product.Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                case Fields.ISSUE:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.Issue.Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                case Fields.COMPANY:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.Company.Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                case Fields.STATE:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.State.Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                case Fields.COMPLAINT_ID:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.ComplainId.ToString().Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                case Fields.ZIP_CODE:
                    datas = await _context.Complains.Select(x => new ComparisonModel()
                    {
                        ComplainId = x.ComplainId,
                        Value = x.ZipCode.Trim().ToLower().Split(),
                        Text = (
                            requestModel.ValueField == Fields.PRODUCT ? x.Product :
                            requestModel.ValueField == Fields.COMPANY ? x.Company :
                            requestModel.ValueField == Fields.ISSUE ? x.Issue :
                            requestModel.ValueField == Fields.STATE ? x.State :
                            requestModel.ValueField == Fields.ZIP_CODE ? x.ZipCode : x.ComplainId.ToString()
                        )
                    }).Take(requestModel.DataCount).ToListAsync();
                    break;
                default:
                    break;
            }

            foreach (var data in datas)
            {
                data.WordCount = data.Value.Count();
            }

            SplitValues(datas, requestModel.ThresholdRatio, requestModel.ThreadCount);
        }

        private void SplitValues(List<ComparisonModel> model, int thresholdRatio, int threadCount)
        {
            var valueCount = model.Count();
            var splittedCount = (int)Math.Ceiling(Convert.ToDecimal(valueCount / threadCount));
            var lists = new List<List<ComparisonModel>>();
            var result = new List<int>();
            
            Thread[] workerThreads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                var splitted = model.Skip(i * splittedCount).Take(splittedCount).ToList();
                workerThreads[i] = new Thread(() => 
                    this.RunThreads(splitted, thresholdRatio)
                );
                workerThreads[i].Start();
            }

            for (int i = 0; i < threadCount; i++)
            {
                workerThreads[i].Join();
            }
        }

        private void RunThreads(List<ComparisonModel> model, int thresholdRatio)
        {
            var watch = Stopwatch.StartNew();

            for (int i = 0; i < model.Count(); i++)
            {
                var item = model[i];
                for (int j = i + 1; j < model.Count(); j++)
                {
                    decimal maxLength = Math.Max(model[j].WordCount, item.WordCount);
                    decimal count = model[j].Value.Intersect(item.Value).Count();

                    var score = Math.Round(Convert.ToDecimal(count / maxLength), 2);
                    if ((score * 100) >= thresholdRatio)
                    {
                        _result.MatchList.Add(new ComparisonResult.MatchModel()
                        {
                            MainId = item.ComplainId,
                            MainValue = item.Text,
                            SimilarId = model[j].ComplainId,
                            SimilarValue = model[j].Text,
                            Rate = score * 100,
                        });
                        model.RemoveAll(x => x.ComplainId == model[j].ComplainId);
                    }
                }
            }

            watch.Stop();

            _result.ThreadList.Add(new ComparisonResult.ThreadModel()
            {
                Name = "Thread " + (_result.ThreadList.Count() + 1),
                Runtime = watch.ElapsedMilliseconds.ToString() + " ms",
            });
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
