// COPYRIGHT 1995-2021 ESRI
// TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
// Unpublished material - all rights reserved under the
// Copyright Laws of the United States and applicable international
// laws, treaties, and conventions.
//
// For additional information, contact:
// Attn: Contracts and Legal Department
// Environmental Systems Research Institute, Inc.
// 380 New York Street
// Redlands, California 92373
// USA
//
// email: legal@esri.com
namespace Esri.ArcGISMapsSDK.Utils.Math
{
	public static class RotatorExtensions
	{
		public static GeoCoord.Rotator ToRotator(this Esri.GameEngine.Location.ArcGISRotation value)
		{
			return new GeoCoord.Rotator(value.Heading, value.Pitch, value.Roll);
		}
	}
}
