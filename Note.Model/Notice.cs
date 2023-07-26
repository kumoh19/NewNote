using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class Notice
    {//DB를 Code First 방식으로
        /// <summary>
        /// 공지사항 번호
        /// </summary>
        [Key]
        public int NoticeNo { get; set; }
        /// <summary>
        /// 공지사항 제목
        /// </summary>
        [Required]
        public string NoticeTitle { get; set; }
        /// <summary>
        /// 공지사항 내용
        /// </summary>
        [Required]
        public string NoticeContents { get; set;}
        /// <summary>
        /// 공지사항 작성일
        /// </summary>
        [Required]
        public DateTime NoticeWriteDate { get; set;}
        /// <summary>
        /// 공지사항 조회수
        /// </summary>
        //[Required]
        //public int NoticeViewCount { get;set;}
    }
}