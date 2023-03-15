using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public string ExamResult { get; set; }
        public int Mark { get; set; }
        public Certificate Certificates { get; set; }
        public int CertificateId { get; set; }
        public Candidate Candidates { get; set; }
        public int CandidateID { get; set; }
        public string DateOfExam { get; set; }

        public Result()
        {

        }

        public Result(int ResultId, string ExamResult, int Mark, Certificate Certificates, Candidate Candidates, string DateOfExam)
        {
            this.ResultId = ResultId;
            this.ExamResult = ExamResult;
            this.Mark = Mark;
            this.Certificates = Certificates;
            this.Candidates = Candidates;
            this.DateOfExam = DateOfExam;
        }

        public Result(string ExamResult, int Mark, Certificate Certificates, Candidate Candidates, string DateOfExam)
        {
            this.ExamResult = ExamResult;
            this.Mark = Mark;
            this.Certificates = Certificates;
            this.Candidates = Candidates;
            this.DateOfExam = DateOfExam;
        }

        public override string ToString()
        {
            return ($"\n\n \nResultId: {ResultId} \ncandidate: {CandidateID} \ncertificates: {CertificateId}\n ExamResult: {ExamResult}\nMark: {Mark}" +
                    $"\nDate: {DateOfExam}");
        }
    }
}
