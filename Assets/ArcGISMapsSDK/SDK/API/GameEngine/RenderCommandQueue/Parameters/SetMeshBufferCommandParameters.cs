// COPYRIGHT 1995-2021 ESRI
// TRADE SECRETS: ESRI PROPRIETARY AND CONFIDENTIAL
// Unpublished material - all rights reserved under the
// Copyright Laws of the United States and applicable international
// laws, treaties, and conventions.
//
// For additional information, contact:
// Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department
// 380 New York Street
// Redlands, California, 92373
// USA
//
// email: contracts@esri.com

using System.Runtime.InteropServices;

namespace Esri.GameEngine.RenderCommandQueue.Parameters
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SetMeshBufferCommandParameters
    {
        /// The scene component parameter of this render command
        /// 
        public uint SceneComponentId;
        
        /// The change type of the mesh buffer
        /// 
        public MeshBufferChangeType MeshBufferChangeType;
        
        /// The buffer parameter of this render command
        /// 
        public GameEngine.RenderCommandQueue.DataBufferView Buffer;
    }
}