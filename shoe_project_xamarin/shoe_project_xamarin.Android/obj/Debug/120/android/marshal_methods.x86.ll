; ModuleID = 'obj\Debug\120\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\120\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [200 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 60
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 89
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 14
	i32 53195887, ; 3: Plugin.Toast.Abstractions => 0x32bb46f => 15
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 84
	i32 88799905, ; 5: Acr.UserDialogs => 0x54afaa1 => 4
	i32 101534019, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 74
	i32 120558881, ; 7: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 74
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 41
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 75
	i32 209399409, ; 10: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 39
	i32 230216969, ; 11: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 55
	i32 232815796, ; 12: System.Web.Services => 0xde07cb4 => 98
	i32 261689757, ; 13: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 44
	i32 278686392, ; 14: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 59
	i32 280482487, ; 15: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 53
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 31
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 26
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 57
	i32 441335492, ; 19: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 43
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 83
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 52
	i32 464011637, ; 22: CarouselView.FormsPlugin.Abstractions => 0x1ba84175 => 6
	i32 465846621, ; 23: mscorlib => 0x1bc4415d => 13
	i32 469710990, ; 24: System.dll => 0x1bff388e => 25
	i32 476646585, ; 25: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 53
	i32 484808150, ; 26: Com.Android.DeskClock.dll => 0x1ce595d6 => 8
	i32 486930444, ; 27: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 64
	i32 526420162, ; 28: System.Transactions.dll => 0x1f6088c2 => 93
	i32 605376203, ; 29: System.IO.Compression.FileSystem => 0x24154ecb => 96
	i32 627609679, ; 30: Xamarin.AndroidX.CustomView => 0x2568904f => 48
	i32 663517072, ; 31: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 80
	i32 666292255, ; 32: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 36
	i32 690569205, ; 33: System.Xml.Linq.dll => 0x29293ff5 => 30
	i32 691439157, ; 34: Acr.UserDialogs.dll => 0x29368635 => 4
	i32 719061231, ; 35: Syncfusion.Core.XForms.dll => 0x2adc00ef => 19
	i32 775507847, ; 36: System.IO.Compression => 0x2e394f87 => 95
	i32 809851609, ; 37: System.Drawing.Common.dll => 0x30455ad9 => 1
	i32 843511501, ; 38: Xamarin.AndroidX.Print => 0x3246f6cd => 71
	i32 928116545, ; 39: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 89
	i32 955402788, ; 40: Newtonsoft.Json => 0x38f24a24 => 14
	i32 967690846, ; 41: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 57
	i32 974778368, ; 42: FormsViewGroup.dll => 0x3a19f000 => 10
	i32 982407071, ; 43: Syncfusion.SfRating.Android.dll => 0x3a8e579f => 21
	i32 1012816738, ; 44: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 73
	i32 1035644815, ; 45: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 35
	i32 1036786681, ; 46: Plugin.Toast => 0x3dcc1bf9 => 16
	i32 1042160112, ; 47: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 86
	i32 1052210849, ; 48: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 61
	i32 1052823365, ; 49: Com.ViewPagerIndicator => 0x3ec0cf45 => 9
	i32 1098259244, ; 50: System => 0x41761b2c => 25
	i32 1175144683, ; 51: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 78
	i32 1178241025, ; 52: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 68
	i32 1204270330, ; 53: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 36
	i32 1243580121, ; 54: Syncfusion.SfRating.XForms.Android => 0x4a1f86d9 => 22
	i32 1267360935, ; 55: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 79
	i32 1293217323, ; 56: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 50
	i32 1365406463, ; 57: System.ServiceModel.Internals.dll => 0x516272ff => 90
	i32 1376866003, ; 58: Xamarin.AndroidX.SavedState => 0x52114ed3 => 73
	i32 1384058635, ; 59: shoe_project_xamarin.Android.dll => 0x527f0f0b => 0
	i32 1395857551, ; 60: Xamarin.AndroidX.Media.dll => 0x5333188f => 65
	i32 1406073936, ; 61: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 45
	i32 1418540974, ; 62: shoe_project_xamarin.dll => 0x548d37ae => 17
	i32 1426028455, ; 63: Plugin.Toast.dll => 0x54ff77a7 => 16
	i32 1429703732, ; 64: Syncfusion.SfRating.XForms.Android.dll => 0x55378c34 => 22
	i32 1460219004, ; 65: Xamarin.Forms.Xaml => 0x57092c7c => 87
	i32 1462112819, ; 66: System.IO.Compression.dll => 0x57261233 => 95
	i32 1469204771, ; 67: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 34
	i32 1516315406, ; 68: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 18
	i32 1582372066, ; 69: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 49
	i32 1592978981, ; 70: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 71: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 63
	i32 1624863272, ; 72: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 82
	i32 1636350590, ; 73: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 47
	i32 1639515021, ; 74: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 75: System.Runtime => 0x62c6282e => 28
	i32 1658241508, ; 76: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 76
	i32 1658251792, ; 77: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 88
	i32 1670060433, ; 78: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 44
	i32 1699677830, ; 79: Syncfusion.SfRating.XForms.dll => 0x654f0686 => 23
	i32 1729485958, ; 80: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 40
	i32 1766324549, ; 81: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 75
	i32 1776026572, ; 82: System.Core.dll => 0x69dc03cc => 24
	i32 1788241197, ; 83: Xamarin.AndroidX.Fragment => 0x6a96652d => 52
	i32 1808609942, ; 84: Xamarin.AndroidX.Loader => 0x6bcd3296 => 63
	i32 1813201214, ; 85: Xamarin.Google.Android.Material => 0x6c13413e => 88
	i32 1818569960, ; 86: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 69
	i32 1867746548, ; 87: Xamarin.Essentials.dll => 0x6f538cf4 => 83
	i32 1878053835, ; 88: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 87
	i32 1885316902, ; 89: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 37
	i32 1919157823, ; 90: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 66
	i32 2019465201, ; 91: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 61
	i32 2055257422, ; 92: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 58
	i32 2079903147, ; 93: System.Runtime.dll => 0x7bf8cdab => 28
	i32 2090596640, ; 94: System.Numerics.Vectors => 0x7c9bf920 => 27
	i32 2097448633, ; 95: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 54
	i32 2126786730, ; 96: Xamarin.Forms.Platform.Android => 0x7ec430aa => 85
	i32 2201231467, ; 97: System.Net.Http => 0x8334206b => 2
	i32 2215538997, ; 98: Syncfusion.SfRating.Android => 0x840e7135 => 21
	i32 2217644978, ; 99: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 78
	i32 2238865308, ; 100: shoe_project_xamarin.Android => 0x85725f9c => 0
	i32 2244775296, ; 101: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 64
	i32 2256548716, ; 102: Xamarin.AndroidX.MultiDex => 0x8680336c => 66
	i32 2261435625, ; 103: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 56
	i32 2279755925, ; 104: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 72
	i32 2315684594, ; 105: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 32
	i32 2343171156, ; 106: Syncfusion.Core.XForms => 0x8ba9f454 => 19
	i32 2354730003, ; 107: Syncfusion.Licensing => 0x8c5a5413 => 20
	i32 2409053734, ; 108: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 70
	i32 2465532216, ; 109: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 43
	i32 2471841756, ; 110: netstandard.dll => 0x93554fdc => 91
	i32 2475788418, ; 111: Java.Interop.dll => 0x93918882 => 11
	i32 2485609088, ; 112: shoe_project_xamarin => 0x94276280 => 17
	i32 2501346920, ; 113: System.Data.DataSetExtensions => 0x95178668 => 94
	i32 2505896520, ; 114: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 60
	i32 2563143864, ; 115: AndHUD.dll => 0x98c678b8 => 5
	i32 2581819634, ; 116: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 79
	i32 2620871830, ; 117: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 47
	i32 2624644809, ; 118: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 51
	i32 2633051222, ; 119: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 59
	i32 2701096212, ; 120: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 76
	i32 2732626843, ; 121: Xamarin.AndroidX.Activity => 0xa2e0939b => 31
	i32 2737747696, ; 122: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 34
	i32 2766581644, ; 123: Xamarin.Forms.Core => 0xa4e6af8c => 84
	i32 2778768386, ; 124: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 81
	i32 2810250172, ; 125: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 45
	i32 2819470561, ; 126: System.Xml.dll => 0xa80db4e1 => 29
	i32 2853208004, ; 127: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 81
	i32 2855708567, ; 128: Xamarin.AndroidX.Transition => 0xaa36a797 => 77
	i32 2867931758, ; 129: Plugin.Toast.Abstractions.dll => 0xaaf12a6e => 15
	i32 2868557005, ; 130: Syncfusion.Licensing.dll => 0xaafab4cd => 20
	i32 2874148507, ; 131: Syncfusion.Core.XForms.Android => 0xab50069b => 18
	i32 2903344695, ; 132: System.ComponentModel.Composition => 0xad0d8637 => 97
	i32 2905242038, ; 133: mscorlib.dll => 0xad2a79b6 => 13
	i32 2916838712, ; 134: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 82
	i32 2919462931, ; 135: System.Numerics.Vectors.dll => 0xae037813 => 27
	i32 2921128767, ; 136: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 33
	i32 2978675010, ; 137: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 50
	i32 3024354802, ; 138: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 55
	i32 3044182254, ; 139: FormsViewGroup => 0xb57288ee => 10
	i32 3057625584, ; 140: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 67
	i32 3111772706, ; 141: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3204380047, ; 142: System.Data.dll => 0xbefef58f => 92
	i32 3211777861, ; 143: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 49
	i32 3243986101, ; 144: CarouselView.FormsPlugin.Droid.dll => 0xc15b4cb5 => 7
	i32 3247949154, ; 145: Mono.Security => 0xc197c562 => 99
	i32 3258312781, ; 146: Xamarin.AndroidX.CardView => 0xc235e84d => 40
	i32 3267021929, ; 147: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 38
	i32 3317135071, ; 148: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 48
	i32 3317144872, ; 149: System.Data => 0xc5b79d28 => 92
	i32 3340431453, ; 150: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 37
	i32 3346324047, ; 151: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 68
	i32 3353484488, ; 152: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 54
	i32 3362522851, ; 153: Xamarin.AndroidX.Core => 0xc86c06e3 => 46
	i32 3366347497, ; 154: Java.Interop => 0xc8a662e9 => 11
	i32 3374999561, ; 155: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 72
	i32 3404865022, ; 156: System.ServiceModel.Internals => 0xcaf21dfe => 90
	i32 3429136800, ; 157: System.Xml => 0xcc6479a0 => 29
	i32 3430777524, ; 158: netstandard => 0xcc7d82b4 => 91
	i32 3441283291, ; 159: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 51
	i32 3442543374, ; 160: AndHUD => 0xcd310b0e => 5
	i32 3476120550, ; 161: Mono.Android => 0xcf3163e6 => 12
	i32 3486566296, ; 162: System.Transactions => 0xcfd0c798 => 93
	i32 3493954962, ; 163: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 42
	i32 3501239056, ; 164: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 38
	i32 3509114376, ; 165: System.Xml.Linq => 0xd128d608 => 30
	i32 3536029504, ; 166: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 85
	i32 3548121443, ; 167: Syncfusion.SfRating.XForms => 0xd37c0963 => 23
	i32 3567349600, ; 168: System.ComponentModel.Composition.dll => 0xd4a16f60 => 97
	i32 3607250274, ; 169: Com.ViewPagerIndicator.dll => 0xd7024562 => 9
	i32 3618140916, ; 170: Xamarin.AndroidX.Preference => 0xd7a872f4 => 70
	i32 3627220390, ; 171: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 71
	i32 3632359727, ; 172: Xamarin.Forms.Platform => 0xd881692f => 86
	i32 3633644679, ; 173: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 33
	i32 3641597786, ; 174: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 58
	i32 3658720537, ; 175: CarouselView.FormsPlugin.Abstractions.dll => 0xda13a519 => 6
	i32 3672681054, ; 176: Mono.Android.dll => 0xdae8aa5e => 12
	i32 3676310014, ; 177: System.Web.Services.dll => 0xdb2009fe => 98
	i32 3682565725, ; 178: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 39
	i32 3684561358, ; 179: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 42
	i32 3689375977, ; 180: System.Drawing.Common => 0xdbe768e9 => 1
	i32 3718780102, ; 181: Xamarin.AndroidX.Annotation => 0xdda814c6 => 32
	i32 3724971120, ; 182: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 67
	i32 3758932259, ; 183: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 56
	i32 3786282454, ; 184: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 41
	i32 3822602673, ; 185: Xamarin.AndroidX.Media => 0xe3d849b1 => 65
	i32 3829621856, ; 186: System.Numerics.dll => 0xe4436460 => 26
	i32 3885922214, ; 187: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 77
	i32 3896760992, ; 188: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 46
	i32 3920810846, ; 189: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 96
	i32 3921031405, ; 190: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 80
	i32 3929156617, ; 191: Com.Android.DeskClock => 0xea322c09 => 8
	i32 3931092270, ; 192: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 69
	i32 3945713374, ; 193: System.Data.DataSetExtensions.dll => 0xeb2ecede => 94
	i32 3955647286, ; 194: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 35
	i32 4105002889, ; 195: Mono.Security.dll => 0xf4ad5f89 => 99
	i32 4125258827, ; 196: CarouselView.FormsPlugin.Droid => 0xf5e2744b => 7
	i32 4151237749, ; 197: System.Core => 0xf76edc75 => 24
	i32 4182413190, ; 198: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 62
	i32 4292120959 ; 199: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 62
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [200 x i32] [
	i32 60, i32 89, i32 14, i32 15, i32 84, i32 4, i32 74, i32 74, ; 0..7
	i32 41, i32 75, i32 39, i32 55, i32 98, i32 44, i32 59, i32 53, ; 8..15
	i32 31, i32 26, i32 57, i32 43, i32 83, i32 52, i32 6, i32 13, ; 16..23
	i32 25, i32 53, i32 8, i32 64, i32 93, i32 96, i32 48, i32 80, ; 24..31
	i32 36, i32 30, i32 4, i32 19, i32 95, i32 1, i32 71, i32 89, ; 32..39
	i32 14, i32 57, i32 10, i32 21, i32 73, i32 35, i32 16, i32 86, ; 40..47
	i32 61, i32 9, i32 25, i32 78, i32 68, i32 36, i32 22, i32 79, ; 48..55
	i32 50, i32 90, i32 73, i32 0, i32 65, i32 45, i32 17, i32 16, ; 56..63
	i32 22, i32 87, i32 95, i32 34, i32 18, i32 49, i32 3, i32 63, ; 64..71
	i32 82, i32 47, i32 2, i32 28, i32 76, i32 88, i32 44, i32 23, ; 72..79
	i32 40, i32 75, i32 24, i32 52, i32 63, i32 88, i32 69, i32 83, ; 80..87
	i32 87, i32 37, i32 66, i32 61, i32 58, i32 28, i32 27, i32 54, ; 88..95
	i32 85, i32 2, i32 21, i32 78, i32 0, i32 64, i32 66, i32 56, ; 96..103
	i32 72, i32 32, i32 19, i32 20, i32 70, i32 43, i32 91, i32 11, ; 104..111
	i32 17, i32 94, i32 60, i32 5, i32 79, i32 47, i32 51, i32 59, ; 112..119
	i32 76, i32 31, i32 34, i32 84, i32 81, i32 45, i32 29, i32 81, ; 120..127
	i32 77, i32 15, i32 20, i32 18, i32 97, i32 13, i32 82, i32 27, ; 128..135
	i32 33, i32 50, i32 55, i32 10, i32 67, i32 3, i32 92, i32 49, ; 136..143
	i32 7, i32 99, i32 40, i32 38, i32 48, i32 92, i32 37, i32 68, ; 144..151
	i32 54, i32 46, i32 11, i32 72, i32 90, i32 29, i32 91, i32 51, ; 152..159
	i32 5, i32 12, i32 93, i32 42, i32 38, i32 30, i32 85, i32 23, ; 160..167
	i32 97, i32 9, i32 70, i32 71, i32 86, i32 33, i32 58, i32 6, ; 168..175
	i32 12, i32 98, i32 39, i32 42, i32 1, i32 32, i32 67, i32 56, ; 176..183
	i32 41, i32 65, i32 26, i32 77, i32 46, i32 96, i32 80, i32 8, ; 184..191
	i32 69, i32 94, i32 35, i32 99, i32 7, i32 24, i32 62, i32 62 ; 200..199
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
