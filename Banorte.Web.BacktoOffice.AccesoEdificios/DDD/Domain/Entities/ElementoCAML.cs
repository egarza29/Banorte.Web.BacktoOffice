using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    public enum CAMLFieldType
    {
        DateTime,
        Lookup,
        Text,
        Number,
        Counter
    }

    public enum CAMLComparisonOperators
    {
        Eq,
        Gt,
        Geq,
        Lt,
        Leq,
        Neq,
        Contains,
        BeginsWith,
        DateRangesOverlap,
        IsNotNull,
        IsNull
    }

    public enum CAMLLogicalJoin
    {
        And,
        Or
    }

    public class ElementoCAML
    {
        public CAMLFieldType FieldType { set; get; }
        public CAMLComparisonOperators ComparisonOperators { set; get; }
        public CAMLLogicalJoin LogicalJoin { set; get; }

        public string FieldTypeStr
        {
            get
            {
                string result = string.Empty;
                switch (FieldType)
                {
                    case CAMLFieldType.Counter:
                        result = "Counter";
                        break;
                    case CAMLFieldType.DateTime:
                        result = "DateTime";
                        break;
                    case CAMLFieldType.Lookup:
                        result = "Lookup";
                        break;
                    case CAMLFieldType.Number:
                        result = "Number";
                        break;
                    case CAMLFieldType.Text:
                        result = "Text";
                        break;
                }
                return result;
            }
        }
        public string ComparisonOperatorsStr
        {
            get
            {
                string result = string.Empty;
                switch (ComparisonOperators)
                {
                    case CAMLComparisonOperators.Eq:
                        result = "Eq";
                        break;
                    case CAMLComparisonOperators.Geq:
                        result = "Geq";
                        break;
                    case CAMLComparisonOperators.Gt:
                        result = "Gt";
                        break;
                    case CAMLComparisonOperators.Leq:
                        result = "Leq";
                        break;
                    case CAMLComparisonOperators.Lt:
                        result = "Lt";
                        break;
                    case CAMLComparisonOperators.Neq:
                        result = "Neq";
                        break;
                    case CAMLComparisonOperators.Contains:
                        result = "Contains";
                        break;
                    case CAMLComparisonOperators.BeginsWith:
                        result = "BeginsWith";
                        break;
                    case CAMLComparisonOperators.DateRangesOverlap:
                        result = "DateRangesOverlap";
                        break;
                    case CAMLComparisonOperators.IsNotNull:
                        result = "IsNotNull";
                        break;
                    case CAMLComparisonOperators.IsNull:
                        result = "IsNull";
                        break;
                }
                return result;
            }
        }
        public string LogicalJoinStr
        {
            get
            {
                string result = string.Empty;
                switch (LogicalJoin)
                {
                    case CAMLLogicalJoin.And:
                        result = "And";
                        break;
                    case CAMLLogicalJoin.Or:
                        result = "Or";
                        break;
                }
                return result;
            }
        }

        public string FieldName { set; get; }
        public string FieldValue { set; get; }
    }
}
