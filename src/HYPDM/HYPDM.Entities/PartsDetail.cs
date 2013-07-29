using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.Entities
{
    public class PartsDetail
    {
        private String proStructID;

        public String ProStructID
        {
            get { return proStructID; }
            set { proStructID = value; }
        }

        private String partsID;

        public String PartsID
        {
            get { return partsID; }
            set { partsID = value; }
        }

        private String partsType;

        public String PartsType
        {
            get { return partsType; }
            set { partsType = value; }
        }

        private String partsNo;

        public String PartsNo
        {
            get { return partsNo; }
            set { partsNo = value; }
        }

        private String version;

        public String Version
        {
            get { return version; }
            set { version = value; }
        }

        private String sortCode;

        public String SortCode
        {
            get { return sortCode; }
            set { sortCode = value; }
        }

        private String quantity;

        public String Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private String specificationCode;

        public String SpecificationCode
        {
            get { return specificationCode; }
            set { specificationCode = value; }
        }

        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        private String remark;

        public String Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        private String singleNetweight;

        public String SingleNetweight
        {
            get { return singleNetweight; }
            set { singleNetweight = value; }
        }

        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        private String lastUpdateUser;

        public String LastUpdateUser
        {
            get { return lastUpdateUser; }
            set { lastUpdateUser = value; }
        }

        private String createDate;

        public String CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private String lastUpdateDate;

        public String LastUpdateDate
        {
            get { return lastUpdateDate; }
            set { lastUpdateDate = value; }
        }

        private String surfaceSolve;

        public String SurfaceSolve
        {
            get { return surfaceSolve; }
            set { surfaceSolve = value; }
        }
    }
}
