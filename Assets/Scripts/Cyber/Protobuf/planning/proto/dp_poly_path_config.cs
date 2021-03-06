// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: dp_poly_path_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class DpPolyPathConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DpPolyPathConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public WaypointSamplerConfig waypoint_sampler_config { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double eval_time_interval
        {
            get { return __pbn__eval_time_interval ?? 0.1; }
            set { __pbn__eval_time_interval = value; }
        }
        public bool ShouldSerializeeval_time_interval()
        {
            return __pbn__eval_time_interval != null;
        }
        public void Reseteval_time_interval()
        {
            __pbn__eval_time_interval = null;
        }
        private double? __pbn__eval_time_interval;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double path_resolution
        {
            get { return __pbn__path_resolution ?? 0.1; }
            set { __pbn__path_resolution = value; }
        }
        public bool ShouldSerializepath_resolution()
        {
            return __pbn__path_resolution != null;
        }
        public void Resetpath_resolution()
        {
            __pbn__path_resolution = null;
        }
        private double? __pbn__path_resolution;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(20)]
        public double obstacle_ignore_distance
        {
            get { return __pbn__obstacle_ignore_distance ?? 20; }
            set { __pbn__obstacle_ignore_distance = value; }
        }
        public bool ShouldSerializeobstacle_ignore_distance()
        {
            return __pbn__obstacle_ignore_distance != null;
        }
        public void Resetobstacle_ignore_distance()
        {
            __pbn__obstacle_ignore_distance = null;
        }
        private double? __pbn__obstacle_ignore_distance;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double obstacle_collision_distance
        {
            get { return __pbn__obstacle_collision_distance ?? 0.2; }
            set { __pbn__obstacle_collision_distance = value; }
        }
        public bool ShouldSerializeobstacle_collision_distance()
        {
            return __pbn__obstacle_collision_distance != null;
        }
        public void Resetobstacle_collision_distance()
        {
            __pbn__obstacle_collision_distance = null;
        }
        private double? __pbn__obstacle_collision_distance;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double obstacle_risk_distance
        {
            get { return __pbn__obstacle_risk_distance ?? 2; }
            set { __pbn__obstacle_risk_distance = value; }
        }
        public bool ShouldSerializeobstacle_risk_distance()
        {
            return __pbn__obstacle_risk_distance != null;
        }
        public void Resetobstacle_risk_distance()
        {
            __pbn__obstacle_risk_distance = null;
        }
        private double? __pbn__obstacle_risk_distance;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(1000)]
        public double obstacle_collision_cost
        {
            get { return __pbn__obstacle_collision_cost ?? 1000; }
            set { __pbn__obstacle_collision_cost = value; }
        }
        public bool ShouldSerializeobstacle_collision_cost()
        {
            return __pbn__obstacle_collision_cost != null;
        }
        public void Resetobstacle_collision_cost()
        {
            __pbn__obstacle_collision_cost = null;
        }
        private double? __pbn__obstacle_collision_cost;

        [global::ProtoBuf.ProtoMember(8)]
        public double path_l_cost
        {
            get { return __pbn__path_l_cost.GetValueOrDefault(); }
            set { __pbn__path_l_cost = value; }
        }
        public bool ShouldSerializepath_l_cost()
        {
            return __pbn__path_l_cost != null;
        }
        public void Resetpath_l_cost()
        {
            __pbn__path_l_cost = null;
        }
        private double? __pbn__path_l_cost;

        [global::ProtoBuf.ProtoMember(9)]
        public double path_dl_cost
        {
            get { return __pbn__path_dl_cost.GetValueOrDefault(); }
            set { __pbn__path_dl_cost = value; }
        }
        public bool ShouldSerializepath_dl_cost()
        {
            return __pbn__path_dl_cost != null;
        }
        public void Resetpath_dl_cost()
        {
            __pbn__path_dl_cost = null;
        }
        private double? __pbn__path_dl_cost;

        [global::ProtoBuf.ProtoMember(10)]
        public double path_ddl_cost
        {
            get { return __pbn__path_ddl_cost.GetValueOrDefault(); }
            set { __pbn__path_ddl_cost = value; }
        }
        public bool ShouldSerializepath_ddl_cost()
        {
            return __pbn__path_ddl_cost != null;
        }
        public void Resetpath_ddl_cost()
        {
            __pbn__path_ddl_cost = null;
        }
        private double? __pbn__path_ddl_cost;

        [global::ProtoBuf.ProtoMember(11)]
        public double path_l_cost_param_l0
        {
            get { return __pbn__path_l_cost_param_l0.GetValueOrDefault(); }
            set { __pbn__path_l_cost_param_l0 = value; }
        }
        public bool ShouldSerializepath_l_cost_param_l0()
        {
            return __pbn__path_l_cost_param_l0 != null;
        }
        public void Resetpath_l_cost_param_l0()
        {
            __pbn__path_l_cost_param_l0 = null;
        }
        private double? __pbn__path_l_cost_param_l0;

        [global::ProtoBuf.ProtoMember(12)]
        public double path_l_cost_param_b
        {
            get { return __pbn__path_l_cost_param_b.GetValueOrDefault(); }
            set { __pbn__path_l_cost_param_b = value; }
        }
        public bool ShouldSerializepath_l_cost_param_b()
        {
            return __pbn__path_l_cost_param_b != null;
        }
        public void Resetpath_l_cost_param_b()
        {
            __pbn__path_l_cost_param_b = null;
        }
        private double? __pbn__path_l_cost_param_b;

        [global::ProtoBuf.ProtoMember(13)]
        public double path_l_cost_param_k
        {
            get { return __pbn__path_l_cost_param_k.GetValueOrDefault(); }
            set { __pbn__path_l_cost_param_k = value; }
        }
        public bool ShouldSerializepath_l_cost_param_k()
        {
            return __pbn__path_l_cost_param_k != null;
        }
        public void Resetpath_l_cost_param_k()
        {
            __pbn__path_l_cost_param_k = null;
        }
        private double? __pbn__path_l_cost_param_k;

        [global::ProtoBuf.ProtoMember(14)]
        public double path_out_lane_cost
        {
            get { return __pbn__path_out_lane_cost.GetValueOrDefault(); }
            set { __pbn__path_out_lane_cost = value; }
        }
        public bool ShouldSerializepath_out_lane_cost()
        {
            return __pbn__path_out_lane_cost != null;
        }
        public void Resetpath_out_lane_cost()
        {
            __pbn__path_out_lane_cost = null;
        }
        private double? __pbn__path_out_lane_cost;

        [global::ProtoBuf.ProtoMember(15)]
        public double path_end_l_cost
        {
            get { return __pbn__path_end_l_cost.GetValueOrDefault(); }
            set { __pbn__path_end_l_cost = value; }
        }
        public bool ShouldSerializepath_end_l_cost()
        {
            return __pbn__path_end_l_cost != null;
        }
        public void Resetpath_end_l_cost()
        {
            __pbn__path_end_l_cost = null;
        }
        private double? __pbn__path_end_l_cost;

    }

}

#pragma warning restore 0612, 1591, 3021
