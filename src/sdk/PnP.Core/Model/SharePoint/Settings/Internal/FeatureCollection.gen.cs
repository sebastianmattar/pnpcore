﻿using PnP.Core.QueryModel.Model;
using PnP.Core.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class FeatureCollection : QueryableDataModelCollection<IFeature>, IFeatureCollection
    {
        public FeatureCollection(PnPContext context, IDataModelParent parent, string memberName = null)
           : base(context, parent, memberName)
        {
            this.PnPContext = context;
            this.Parent = parent;
        }
        
        private Feature AddNewFeature()
        {
            var newFeature = NewFeature();
            this.items.Add(newFeature);
            return newFeature;
        }

        private void RemoveFeature(IFeature feature)
        {
            this.items.Remove(feature);
        }

        private Feature NewFeature()
        {
            var newFeature = new Feature
            {
                PnPContext = this.PnPContext,
                Parent = this,
            };
            return newFeature;
        }

    }
}