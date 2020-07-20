using System;
using UnityEditor.iOS.Xcode;

namespace Kogane
{
	/// <summary>
	/// PlistDocument のラッパークラス
	/// </summary>
	public sealed class PlistDocumentWrapper : IDisposable
	{
		//================================================================================
		// 変数(readonly)
		//================================================================================
		private readonly PlistDocument m_plist;
		private readonly string        m_path;

		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 指定されたパスに存在する .plist を読み込みます
		/// </summary>
		public PlistDocumentWrapper( string path )
		{
			m_path  = path;
			m_plist = new PlistDocument();
			m_plist.ReadFromFile( m_path );
		}

		/// <summary>
		/// .plist を保存します
		/// </summary>
		public void Dispose()
		{
			m_plist.WriteToFile( m_path );
		}

		/// <summary>
		/// CFBundleDevelopmentRegion を設定します
		/// </summary>
		public void SetBundleDevelopmentRegion( bool isJapan )
		{
			var value = isJapan ? "ja" : "en";
			SetString( "CFBundleDevelopmentRegion", value );
		}

		/// <summary>
		/// キーに紐づく値を設定します
		/// </summary>
		public void SetString( string key, string val )
		{
			m_plist.root.SetString( key, val );
		}
	}
}