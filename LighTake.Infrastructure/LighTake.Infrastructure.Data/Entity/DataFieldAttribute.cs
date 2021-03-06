using System;
using System.Data;

namespace LighTake.Infrastructure.Data.Entity
{

    /// <summary>
    /// 数据库实体映射类
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
    public class DataFieldAttribute : Attribute
    {
        DbType _columnType = DbType.String;
        bool _primaryKey;
        bool _unique;

        public DataFieldAttribute(string columnName)
        {
            ColumnName = columnName;
        }


        /// <summary>
        /// 屬性在數據庫中的名稱
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// 屬性說明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 屬性在數據庫中的類型
        /// </summary>
        public DbType ColumnType
        {
            get { return _columnType; }
            set { _columnType = value; }
        }

        /// <summary>
        /// 屬性大小
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 是否為主鍵
        /// </summary>
        public bool PrimaryKey
        {
            get { return _primaryKey; }
            set
            {
                _primaryKey = value;
                if (value) _unique = true;
            }
        }

        /// <summary>
        /// 是否唯一
        /// </summary>
        public bool Unique
        {
            get { return _unique; }
            set { _unique = value; }
        }

        /// <summary>
        /// 是否為視圖字段(如為主題的字段則為false)
        /// </summary>
        public bool View { get; set; }

        /// <summary>
        /// 是否存在默認值
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// 表示新增時是否自動增長
        /// </summary>
        public bool Identity { get; set; }

        /// <summary>
        /// 表示修改時,空值或null是否处理此栏位
        /// </summary>
        public bool EmptyUpdate { get; set; }
    }
}
