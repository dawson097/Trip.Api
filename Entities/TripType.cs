﻿namespace Trip.Api.Entities;

/// <summary>
/// 旅游类型
/// </summary>
public enum TripType
{
    HotelAndAttractions, // 酒店+景点
    Group, // 跟团游
    PrivateGroup, // 私家团
    BackPackTour, // 自由行
    SemiBackPackTour // 半自助游
}