//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project4Aptech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionHistory
    {
        public int Id { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
        public string SendAccount { get; set; }
        public string ReceiveAccount { get; set; }
        public string Status { get; set; }
        public Nullable<int> Bank_id { get; set; }
        public string tran_time { get; set; }
        public Nullable<double> fee { get; set; }
    
        public virtual Banks Banks { get; set; }
    }
}