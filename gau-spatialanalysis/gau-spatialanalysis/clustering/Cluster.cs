﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MathNet.Spatial.Euclidean;

/// <summary>
/// TODO: make generic some time
/// </summary>
namespace Clustering 
{
    public class Cluster<T>
    {
        /// <summary>
        /// Data points assigned to this cluster
        /// </summary>
        public List<T> data;

        /// <summary>
        /// Centroid or Medoid of this cluster 
        /// </summary>
        public T representative;

        /// <summary>
        /// Create an empty cluster - add datapoints
        /// </summary>
        public Cluster()
        {
            this.data = new List<T>();
        }

        /// <summary>
        /// Create a cluster with three-dimensional data
        /// </summary>
        /// <param name="data"></param>
        public Cluster(T[] data)
        {
            this.data = data.ToList();
        }

        /// <summary>
        /// Create cluster with one starting datapoint
        /// </summary>
        /// <param name="datapoint"></param>
        public Cluster(T datapoint)
        {
            this.data = new List<T>();
            assignToCluster(datapoint);
        }

        /// <summary>
        /// Add a datapoint to the cluster
        /// </summary>
        /// <param name="p"></param>
        internal void assignToCluster(T p)
        {
            data.Add(p);
        }

    }
}