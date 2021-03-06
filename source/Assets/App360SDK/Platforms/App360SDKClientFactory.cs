﻿using UnityEngine;
using System.Collections;
using App360SDK.Common;

namespace App360SDK
{
	internal class App360SDKClientFactory
	{
		internal static IStatusRequestClient getCheckTransationRequest (IStatusRequestListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSStatusRequestClient(listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidStatusRequestClient(listener);
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPStatusRequestClient(listener);
			#else
			return null;
			#endif
		}

		internal static IBankRequestClient getBankRequest (IBankRequestListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSBankRequestClient(listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidBankRequestClient(listener);
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPBankRequestClient(listener);
			#else
			return null;
			#endif
		}

		internal static ISMSRequestClient getSMSRequest (ISMSRequestListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSSMSRequestClient(listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidSMSRequestClient(listener);			
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPSMSRequestClient(listener);
			#else
			return null;
			#endif
		}

		internal static ICardRequestClient getCardRequest (ICardRequestListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSCardRequestClient(listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidCardRequestClient(listener);		
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPCardRequestClient(listener);
			#else
			return null;
			#endif
		}

		internal static IApp360SDKClient getApp360SDKClient (IInitListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSApp360SDKClient(listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidApp360SDKClient(listener);		
			#elif UNITY_WP8
			
			return new App360SDK.Platforms.WP8.WPApp360SDKClient(listener);
			#else
			return null;
			#endif 
		}

		internal static ISessionManagerClient getSessionManagerClient (ISessionListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSSessionManagerClient (listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidSessionManagerClient(listener);		
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPSessionManagerClient(listener);
			#else
			return null;
			#endif
		}

		internal static IScopedUserClient getScopedUserClient (IScopedUserListener listener)
		{
			#if UNITY_IOS
			return new App360SDK.iOS.IOSScopedUserClient (listener);
			#elif UNITY_ANDROID
			return new App360SDK.Android.AndroidScopedUserClient(listener);		
			#elif UNITY_WP8
			return new App360SDK.Platforms.WP8.WPScopedUserClient(listener);
			#else
			return null;
			#endif
		}
	}
}
