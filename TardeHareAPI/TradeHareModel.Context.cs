﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TardeHareAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TRADEHAREDBEntities : DbContext
    {
        public TRADEHAREDBEntities()
            : base("name=TRADEHAREDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<CommodityList> CommodityLists { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<NotifyParty> NotifyParties { get; set; }
        public virtual DbSet<Packer> Packers { get; set; }
        public virtual DbSet<Packing> Packings { get; set; }
        public virtual DbSet<PortList> PortLists { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Representative> Representatives { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TagDetail> TagDetails { get; set; }
        public virtual DbSet<TagMaster> TagMasters { get; set; }
        public virtual DbSet<UserAuth> UserAuths { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<uvwLastPurchaseDetail> uvwLastPurchaseDetails { get; set; }
        public virtual DbSet<uvwLastSellerDetail> uvwLastSellerDetails { get; set; }
    
        public virtual ObjectResult<CommodityList> GetCommodity(Nullable<int> comId, string commodityName)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CommodityList>("GetCommodity", comIdParameter, commodityNameParameter);
        }
    
        public virtual ObjectResult<CommodityList> GetCommodity(Nullable<int> comId, string commodityName, MergeOption mergeOption)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CommodityList>("GetCommodity", mergeOption, comIdParameter, commodityNameParameter);
        }
    
        public virtual int AddCommodity(string commodityName, string commoditySpec, string tradeRules, Nullable<byte> userId, ObjectParameter id)
        {
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            var commoditySpecParameter = commoditySpec != null ?
                new ObjectParameter("CommoditySpec", commoditySpec) :
                new ObjectParameter("CommoditySpec", typeof(string));
    
            var tradeRulesParameter = tradeRules != null ?
                new ObjectParameter("TradeRules", tradeRules) :
                new ObjectParameter("TradeRules", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCommodity", commodityNameParameter, commoditySpecParameter, tradeRulesParameter, userIdParameter, id);
        }
    
        public virtual int UpdateCommodity(Nullable<int> comId, string commodityName, string commoditySpec, string tradeTules, Nullable<byte> active, Nullable<byte> userId)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            var commoditySpecParameter = commoditySpec != null ?
                new ObjectParameter("CommoditySpec", commoditySpec) :
                new ObjectParameter("CommoditySpec", typeof(string));
    
            var tradeTulesParameter = tradeTules != null ?
                new ObjectParameter("TradeTules", tradeTules) :
                new ObjectParameter("TradeTules", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCommodity", comIdParameter, commodityNameParameter, commoditySpecParameter, tradeTulesParameter, activeParameter, userIdParameter);
        }
    
        public virtual int AddPort(string portName, string portType, Nullable<byte> userId, ObjectParameter id)
        {
            var portNameParameter = portName != null ?
                new ObjectParameter("PortName", portName) :
                new ObjectParameter("PortName", typeof(string));
    
            var portTypeParameter = portType != null ?
                new ObjectParameter("PortType", portType) :
                new ObjectParameter("PortType", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPort", portNameParameter, portTypeParameter, userIdParameter, id);
        }
    
        public virtual int UpdatePort(Nullable<int> portId, string portName, string portType, Nullable<byte> active, Nullable<byte> userId)
        {
            var portIdParameter = portId.HasValue ?
                new ObjectParameter("PortId", portId) :
                new ObjectParameter("PortId", typeof(int));
    
            var portNameParameter = portName != null ?
                new ObjectParameter("PortName", portName) :
                new ObjectParameter("PortName", typeof(string));
    
            var portTypeParameter = portType != null ?
                new ObjectParameter("PortType", portType) :
                new ObjectParameter("PortType", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePort", portIdParameter, portNameParameter, portTypeParameter, activeParameter, userIdParameter);
        }
    
        public virtual ObjectResult<PortList> GetAllPorts(Nullable<int> portId, string portType)
        {
            var portIdParameter = portId.HasValue ?
                new ObjectParameter("PortId", portId) :
                new ObjectParameter("PortId", typeof(int));
    
            var portTypeParameter = portType != null ?
                new ObjectParameter("PortType", portType) :
                new ObjectParameter("PortType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PortList>("GetAllPorts", portIdParameter, portTypeParameter);
        }
    
        public virtual ObjectResult<PortList> GetAllPorts(Nullable<int> portId, string portType, MergeOption mergeOption)
        {
            var portIdParameter = portId.HasValue ?
                new ObjectParameter("PortId", portId) :
                new ObjectParameter("PortId", typeof(int));
    
            var portTypeParameter = portType != null ?
                new ObjectParameter("PortType", portType) :
                new ObjectParameter("PortType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PortList>("GetAllPorts", mergeOption, portIdParameter, portTypeParameter);
        }
    }
}
