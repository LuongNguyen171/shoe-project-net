; ModuleID = 'obj\Debug\120\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\120\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [192 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 56
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 85
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 10
	i32 53195887, ; 3: Plugin.Toast.Abstractions => 0x32bb46f => 11
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 80
	i32 88799905, ; 5: Acr.UserDialogs => 0x54afaa1 => 4
	i32 101534019, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 70
	i32 120558881, ; 7: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 70
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 37
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 71
	i32 209399409, ; 10: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 35
	i32 230216969, ; 11: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 51
	i32 232815796, ; 12: System.Web.Services => 0xde07cb4 => 94
	i32 261689757, ; 13: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 40
	i32 278686392, ; 14: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 55
	i32 280482487, ; 15: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 49
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 27
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 22
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 53
	i32 441335492, ; 19: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 39
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 79
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 48
	i32 465846621, ; 22: mscorlib => 0x1bc4415d => 9
	i32 469710990, ; 23: System.dll => 0x1bff388e => 21
	i32 476646585, ; 24: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 49
	i32 486930444, ; 25: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 60
	i32 526420162, ; 26: System.Transactions.dll => 0x1f6088c2 => 89
	i32 605376203, ; 27: System.IO.Compression.FileSystem => 0x24154ecb => 92
	i32 627609679, ; 28: Xamarin.AndroidX.CustomView => 0x2568904f => 44
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 76
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 32
	i32 690569205, ; 31: System.Xml.Linq.dll => 0x29293ff5 => 26
	i32 691439157, ; 32: Acr.UserDialogs.dll => 0x29368635 => 4
	i32 719061231, ; 33: Syncfusion.Core.XForms.dll => 0x2adc00ef => 15
	i32 775507847, ; 34: System.IO.Compression => 0x2e394f87 => 91
	i32 809851609, ; 35: System.Drawing.Common.dll => 0x30455ad9 => 1
	i32 843511501, ; 36: Xamarin.AndroidX.Print => 0x3246f6cd => 67
	i32 928116545, ; 37: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 85
	i32 955402788, ; 38: Newtonsoft.Json => 0x38f24a24 => 10
	i32 967690846, ; 39: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 53
	i32 974778368, ; 40: FormsViewGroup.dll => 0x3a19f000 => 6
	i32 982407071, ; 41: Syncfusion.SfRating.Android.dll => 0x3a8e579f => 17
	i32 1012816738, ; 42: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 69
	i32 1035644815, ; 43: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 31
	i32 1036786681, ; 44: Plugin.Toast => 0x3dcc1bf9 => 12
	i32 1042160112, ; 45: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 82
	i32 1052210849, ; 46: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 57
	i32 1098259244, ; 47: System => 0x41761b2c => 21
	i32 1175144683, ; 48: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 74
	i32 1178241025, ; 49: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 64
	i32 1204270330, ; 50: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 32
	i32 1243580121, ; 51: Syncfusion.SfRating.XForms.Android => 0x4a1f86d9 => 18
	i32 1267360935, ; 52: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 75
	i32 1293217323, ; 53: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 46
	i32 1365406463, ; 54: System.ServiceModel.Internals.dll => 0x516272ff => 86
	i32 1376866003, ; 55: Xamarin.AndroidX.SavedState => 0x52114ed3 => 69
	i32 1384058635, ; 56: shoe_project_xamarin.Android.dll => 0x527f0f0b => 0
	i32 1395857551, ; 57: Xamarin.AndroidX.Media.dll => 0x5333188f => 61
	i32 1406073936, ; 58: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 41
	i32 1418540974, ; 59: shoe_project_xamarin.dll => 0x548d37ae => 13
	i32 1426028455, ; 60: Plugin.Toast.dll => 0x54ff77a7 => 12
	i32 1429703732, ; 61: Syncfusion.SfRating.XForms.Android.dll => 0x55378c34 => 18
	i32 1460219004, ; 62: Xamarin.Forms.Xaml => 0x57092c7c => 83
	i32 1462112819, ; 63: System.IO.Compression.dll => 0x57261233 => 91
	i32 1469204771, ; 64: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 30
	i32 1516315406, ; 65: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 14
	i32 1582372066, ; 66: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 45
	i32 1592978981, ; 67: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 68: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 59
	i32 1624863272, ; 69: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 78
	i32 1636350590, ; 70: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 43
	i32 1639515021, ; 71: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 72: System.Runtime => 0x62c6282e => 24
	i32 1658241508, ; 73: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 72
	i32 1658251792, ; 74: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 84
	i32 1670060433, ; 75: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 40
	i32 1699677830, ; 76: Syncfusion.SfRating.XForms.dll => 0x654f0686 => 19
	i32 1729485958, ; 77: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 36
	i32 1766324549, ; 78: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 71
	i32 1776026572, ; 79: System.Core.dll => 0x69dc03cc => 20
	i32 1788241197, ; 80: Xamarin.AndroidX.Fragment => 0x6a96652d => 48
	i32 1808609942, ; 81: Xamarin.AndroidX.Loader => 0x6bcd3296 => 59
	i32 1813201214, ; 82: Xamarin.Google.Android.Material => 0x6c13413e => 84
	i32 1818569960, ; 83: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 65
	i32 1867746548, ; 84: Xamarin.Essentials.dll => 0x6f538cf4 => 79
	i32 1878053835, ; 85: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 83
	i32 1885316902, ; 86: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 33
	i32 1919157823, ; 87: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 62
	i32 2019465201, ; 88: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 57
	i32 2055257422, ; 89: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 54
	i32 2079903147, ; 90: System.Runtime.dll => 0x7bf8cdab => 24
	i32 2090596640, ; 91: System.Numerics.Vectors => 0x7c9bf920 => 23
	i32 2097448633, ; 92: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 50
	i32 2126786730, ; 93: Xamarin.Forms.Platform.Android => 0x7ec430aa => 81
	i32 2201231467, ; 94: System.Net.Http => 0x8334206b => 2
	i32 2215538997, ; 95: Syncfusion.SfRating.Android => 0x840e7135 => 17
	i32 2217644978, ; 96: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 74
	i32 2238865308, ; 97: shoe_project_xamarin.Android => 0x85725f9c => 0
	i32 2244775296, ; 98: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 60
	i32 2256548716, ; 99: Xamarin.AndroidX.MultiDex => 0x8680336c => 62
	i32 2261435625, ; 100: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 52
	i32 2279755925, ; 101: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 68
	i32 2315684594, ; 102: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 28
	i32 2343171156, ; 103: Syncfusion.Core.XForms => 0x8ba9f454 => 15
	i32 2354730003, ; 104: Syncfusion.Licensing => 0x8c5a5413 => 16
	i32 2409053734, ; 105: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 66
	i32 2465532216, ; 106: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 39
	i32 2471841756, ; 107: netstandard.dll => 0x93554fdc => 87
	i32 2475788418, ; 108: Java.Interop.dll => 0x93918882 => 7
	i32 2485609088, ; 109: shoe_project_xamarin => 0x94276280 => 13
	i32 2501346920, ; 110: System.Data.DataSetExtensions => 0x95178668 => 90
	i32 2505896520, ; 111: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 56
	i32 2563143864, ; 112: AndHUD.dll => 0x98c678b8 => 5
	i32 2581819634, ; 113: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 75
	i32 2620871830, ; 114: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 43
	i32 2624644809, ; 115: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 47
	i32 2633051222, ; 116: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 55
	i32 2701096212, ; 117: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 72
	i32 2732626843, ; 118: Xamarin.AndroidX.Activity => 0xa2e0939b => 27
	i32 2737747696, ; 119: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 30
	i32 2766581644, ; 120: Xamarin.Forms.Core => 0xa4e6af8c => 80
	i32 2778768386, ; 121: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 77
	i32 2810250172, ; 122: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 41
	i32 2819470561, ; 123: System.Xml.dll => 0xa80db4e1 => 25
	i32 2853208004, ; 124: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 77
	i32 2855708567, ; 125: Xamarin.AndroidX.Transition => 0xaa36a797 => 73
	i32 2867931758, ; 126: Plugin.Toast.Abstractions.dll => 0xaaf12a6e => 11
	i32 2868557005, ; 127: Syncfusion.Licensing.dll => 0xaafab4cd => 16
	i32 2874148507, ; 128: Syncfusion.Core.XForms.Android => 0xab50069b => 14
	i32 2903344695, ; 129: System.ComponentModel.Composition => 0xad0d8637 => 93
	i32 2905242038, ; 130: mscorlib.dll => 0xad2a79b6 => 9
	i32 2916838712, ; 131: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 78
	i32 2919462931, ; 132: System.Numerics.Vectors.dll => 0xae037813 => 23
	i32 2921128767, ; 133: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 29
	i32 2978675010, ; 134: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 46
	i32 3024354802, ; 135: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 51
	i32 3044182254, ; 136: FormsViewGroup => 0xb57288ee => 6
	i32 3057625584, ; 137: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 63
	i32 3111772706, ; 138: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3204380047, ; 139: System.Data.dll => 0xbefef58f => 88
	i32 3211777861, ; 140: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 45
	i32 3247949154, ; 141: Mono.Security => 0xc197c562 => 95
	i32 3258312781, ; 142: Xamarin.AndroidX.CardView => 0xc235e84d => 36
	i32 3267021929, ; 143: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 34
	i32 3317135071, ; 144: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 44
	i32 3317144872, ; 145: System.Data => 0xc5b79d28 => 88
	i32 3340431453, ; 146: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 33
	i32 3346324047, ; 147: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 64
	i32 3353484488, ; 148: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 50
	i32 3362522851, ; 149: Xamarin.AndroidX.Core => 0xc86c06e3 => 42
	i32 3366347497, ; 150: Java.Interop => 0xc8a662e9 => 7
	i32 3374999561, ; 151: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 68
	i32 3404865022, ; 152: System.ServiceModel.Internals => 0xcaf21dfe => 86
	i32 3429136800, ; 153: System.Xml => 0xcc6479a0 => 25
	i32 3430777524, ; 154: netstandard => 0xcc7d82b4 => 87
	i32 3441283291, ; 155: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 47
	i32 3442543374, ; 156: AndHUD => 0xcd310b0e => 5
	i32 3476120550, ; 157: Mono.Android => 0xcf3163e6 => 8
	i32 3486566296, ; 158: System.Transactions => 0xcfd0c798 => 89
	i32 3493954962, ; 159: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 38
	i32 3501239056, ; 160: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 34
	i32 3509114376, ; 161: System.Xml.Linq => 0xd128d608 => 26
	i32 3536029504, ; 162: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 81
	i32 3548121443, ; 163: Syncfusion.SfRating.XForms => 0xd37c0963 => 19
	i32 3567349600, ; 164: System.ComponentModel.Composition.dll => 0xd4a16f60 => 93
	i32 3618140916, ; 165: Xamarin.AndroidX.Preference => 0xd7a872f4 => 66
	i32 3627220390, ; 166: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 67
	i32 3632359727, ; 167: Xamarin.Forms.Platform => 0xd881692f => 82
	i32 3633644679, ; 168: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 29
	i32 3641597786, ; 169: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 54
	i32 3672681054, ; 170: Mono.Android.dll => 0xdae8aa5e => 8
	i32 3676310014, ; 171: System.Web.Services.dll => 0xdb2009fe => 94
	i32 3682565725, ; 172: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 35
	i32 3684561358, ; 173: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 38
	i32 3689375977, ; 174: System.Drawing.Common => 0xdbe768e9 => 1
	i32 3718780102, ; 175: Xamarin.AndroidX.Annotation => 0xdda814c6 => 28
	i32 3724971120, ; 176: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 63
	i32 3758932259, ; 177: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 52
	i32 3786282454, ; 178: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 37
	i32 3822602673, ; 179: Xamarin.AndroidX.Media => 0xe3d849b1 => 61
	i32 3829621856, ; 180: System.Numerics.dll => 0xe4436460 => 22
	i32 3885922214, ; 181: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 73
	i32 3896760992, ; 182: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 42
	i32 3920810846, ; 183: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 92
	i32 3921031405, ; 184: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 76
	i32 3931092270, ; 185: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 65
	i32 3945713374, ; 186: System.Data.DataSetExtensions.dll => 0xeb2ecede => 90
	i32 3955647286, ; 187: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 31
	i32 4105002889, ; 188: Mono.Security.dll => 0xf4ad5f89 => 95
	i32 4151237749, ; 189: System.Core => 0xf76edc75 => 20
	i32 4182413190, ; 190: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 58
	i32 4292120959 ; 191: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 58
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [192 x i32] [
	i32 56, i32 85, i32 10, i32 11, i32 80, i32 4, i32 70, i32 70, ; 0..7
	i32 37, i32 71, i32 35, i32 51, i32 94, i32 40, i32 55, i32 49, ; 8..15
	i32 27, i32 22, i32 53, i32 39, i32 79, i32 48, i32 9, i32 21, ; 16..23
	i32 49, i32 60, i32 89, i32 92, i32 44, i32 76, i32 32, i32 26, ; 24..31
	i32 4, i32 15, i32 91, i32 1, i32 67, i32 85, i32 10, i32 53, ; 32..39
	i32 6, i32 17, i32 69, i32 31, i32 12, i32 82, i32 57, i32 21, ; 40..47
	i32 74, i32 64, i32 32, i32 18, i32 75, i32 46, i32 86, i32 69, ; 48..55
	i32 0, i32 61, i32 41, i32 13, i32 12, i32 18, i32 83, i32 91, ; 56..63
	i32 30, i32 14, i32 45, i32 3, i32 59, i32 78, i32 43, i32 2, ; 64..71
	i32 24, i32 72, i32 84, i32 40, i32 19, i32 36, i32 71, i32 20, ; 72..79
	i32 48, i32 59, i32 84, i32 65, i32 79, i32 83, i32 33, i32 62, ; 80..87
	i32 57, i32 54, i32 24, i32 23, i32 50, i32 81, i32 2, i32 17, ; 88..95
	i32 74, i32 0, i32 60, i32 62, i32 52, i32 68, i32 28, i32 15, ; 96..103
	i32 16, i32 66, i32 39, i32 87, i32 7, i32 13, i32 90, i32 56, ; 104..111
	i32 5, i32 75, i32 43, i32 47, i32 55, i32 72, i32 27, i32 30, ; 112..119
	i32 80, i32 77, i32 41, i32 25, i32 77, i32 73, i32 11, i32 16, ; 120..127
	i32 14, i32 93, i32 9, i32 78, i32 23, i32 29, i32 46, i32 51, ; 128..135
	i32 6, i32 63, i32 3, i32 88, i32 45, i32 95, i32 36, i32 34, ; 136..143
	i32 44, i32 88, i32 33, i32 64, i32 50, i32 42, i32 7, i32 68, ; 144..151
	i32 86, i32 25, i32 87, i32 47, i32 5, i32 8, i32 89, i32 38, ; 152..159
	i32 34, i32 26, i32 81, i32 19, i32 93, i32 66, i32 67, i32 82, ; 160..167
	i32 29, i32 54, i32 8, i32 94, i32 35, i32 38, i32 1, i32 28, ; 168..175
	i32 63, i32 52, i32 37, i32 61, i32 22, i32 73, i32 42, i32 92, ; 176..183
	i32 76, i32 65, i32 90, i32 31, i32 95, i32 20, i32 58, i32 58 ; 192..191
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
