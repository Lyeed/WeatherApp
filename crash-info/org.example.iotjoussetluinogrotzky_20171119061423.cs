S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: iotjoussetluinogrotzky
PID: 2920
Date: 2017-11-19 06:14:23+0900
Executable File Path: /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb77bc580

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x000001a2, esi = 0xbfbd69e0
ebp = 0xbfbd65f8, esp = 0xbfbd65d0
eax = 0x00000000, ebx = 0xb6e7e000
ecx = 0x00000001, edx = 0xb77bc580
eip = 0xb6d2f090

Memory Information
MemTotal:      250 KB
MemFree:       167 KB
Buffers:         3 KB
Cached:     141200 KB
VmPeak:      98424 KB
VmSize:      98424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16632 KB
VmRSS:       16632 KB
VmData:      37408 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34392 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2920 TID = 2920
2920 3027 3295 3296 3297 

Maps Information
b2c09000 b2c13000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c19000 b2c25000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c26000 b2c47000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c4c000 b2c4d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c4e000 b2c53000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c54000 b2c56000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c57000 b2c59000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c5a000 b2c66000 r-xp /usr/lib/libdrm.so.2.4.0
b2c67000 b2c6a000 r-xp /usr/lib/libdri2.so.0.0.0
b2c6b000 b2c75000 r-xp /usr/lib/libtbm.so.1.0.0
b2c76000 b2c8b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c8c000 b2c9e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34a0000 b34d1000 r-xp /usr/lib/libidn.so.11.5.44
b34d2000 b34f4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34f5000 b3505000 r-xp /usr/lib/libcares.so.2.1.0
b3506000 b3526000 r-xp /usr/lib/libnetwork.so.0.0.0
b3527000 b359e000 r-xp /usr/lib/libcurl.so.4.3.0
b35a0000 b35b4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b35bb000 b35bc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35bd000 b35be000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35bf000 b35c2000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c3000 b35c6000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36ce000 b36d4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d5000 b3819000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3829000 b382a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b382b000 b382c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b382d000 b3836000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3837000 b3839000 r-xp /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky
b383b000 b3874000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4277000 b4282000 r-xp /lib/libnss_files-2.20-2014.11.so
b4284000 b428f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4291000 b42a8000 r-xp /lib/libnsl-2.20-2014.11.so
b42ac000 b42b4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b6000 b42da000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42db000 b42dc000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42dd000 b42e0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e1000 b42e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e9000 b42f3000 r-xp /usr/lib/libsensord-share.so
b42f4000 b4310000 r-xp /usr/lib/libsensor.so.1.2.0
b4312000 b431b000 r-xp /usr/lib/libappcore-common.so.1.1
b431e000 b4320000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4335000 b4337000 r-xp /usr/lib/libXau.so.6.0.0
b4338000 b435a000 r-xp /usr/lib/libxcb.so.1.1.0
b435c000 b4365000 r-xp /lib/libcrypt-2.20-2014.11.so
b438e000 b4390000 r-xp /usr/lib/libiri.so
b4391000 b43b7000 r-xp /lib/libexpat.so.1.5.2
b43b9000 b4424000 r-xp /usr/lib/libssl.so.1.0.0
b442a000 b4436000 r-xp /usr/lib/libethumb.so.1.13.0
b4437000 b443b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b443c000 b468d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c08000 b5c18000 r-xp /usr/lib/libXi.so.6.1.0
b5c19000 b5c1b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c1c000 b5c22000 r-xp /usr/lib/libXtst.so.6.1.0
b5c23000 b5c2d000 r-xp /usr/lib/libXrender.so.1.3.0
b5c2e000 b5c37000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c39000 b5c3b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c3c000 b5c41000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c42000 b5c54000 r-xp /usr/lib/libXext.so.6.4.0
b5c55000 b5c57000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c58000 b5c5a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c5c000 b5d9e000 r-xp /usr/lib/libX11.so.6.3.0
b5da2000 b5dac000 r-xp /usr/lib/libXcursor.so.1.0.2
b5dad000 b5dc3000 r-xp /usr/lib/libudev.so.1.6.0
b5dc6000 b5dca000 r-xp /lib/libattr.so.1.1.0
b5dcb000 b5dfa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dfc000 b5e02000 r-xp /usr/lib/libffi.so.6.0.2
b5e03000 b5e26000 r-xp /lib/libz.so.1.2.8
b5e27000 b5e2a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2b000 b5f87000 r-xp /usr/lib/libxml2.so.2.9.2
b5f8d000 b6074000 r-xp /usr/lib/libstdc++.so.6.0.20
b6081000 b6084000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6085000 b60a7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60a8000 b60bc000 r-xp /lib/libresolv-2.20-2014.11.so
b60c0000 b60e4000 r-xp /usr/lib/liblzma.so.5.0.3
b60e5000 b60e7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60e9000 b60f3000 r-xp /usr/lib/libembryo.so.1.13.0
b60f4000 b611d000 r-xp /usr/lib/libpng12.so.0.50.0
b611e000 b6167000 r-xp /usr/lib/libjpeg.so.8.0.2
b6178000 b617f000 r-xp /lib/librt-2.20-2014.11.so
b6181000 b61a0000 r-xp /usr/lib/libector.so.1.13.0
b61a3000 b61d0000 r-xp /usr/lib/liblua-5.1.so
b61d1000 b6261000 r-xp /usr/lib/libfreetype.so.6.11.3
b6265000 b62a3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a4000 b62ba000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bb000 b6314000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6317000 b6362000 r-xp /lib/libm-2.20-2014.11.so
b6364000 b6376000 r-xp /usr/lib/libeio.so.1.13.0
b6377000 b637a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637b000 b6381000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6382000 b63a5000 r-xp /usr/lib/libefreet.so.1.13.0
b63a8000 b63d3000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d4000 b6408000 r-xp /usr/lib/libecore_con.so.1.13.0
b640a000 b6413000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6414000 b641d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b641e000 b6431000 r-xp /usr/lib/libeo.so.1.13.0
b6433000 b6446000 r-xp /usr/lib/libecore_input.so.1.13.0
b6447000 b644e000 r-xp /usr/lib/libecore_file.so.1.13.0
b644f000 b6472000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6473000 b649f000 r-xp /usr/lib/libeet.so.1.13.0
b64a8000 b6513000 r-xp /usr/lib/libeina.so.1.13.0
b6516000 b652d000 r-xp /usr/lib/libefl.so.1.13.0
b652f000 b6696000 r-xp /usr/lib/libicuuc.so.51.1
b66a4000 b68b0000 r-xp /usr/lib/libicui18n.so.51.1
b68b8000 b6907000 r-xp /usr/lib/libecore_x.so.1.13.0
b6909000 b6923000 r-xp /lib/libgcc_s-4.9.so.1
b6925000 b6929000 r-xp /lib/libcap.so.2.21
b692a000 b6970000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6971000 b6978000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697a000 b69cc000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69ce000 b6b59000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b5e000 b6c2c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c2f000 b6c33000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c34000 b6c43000 r-xp /usr/lib/libvconf.so.0.2.45
b6c44000 b6c47000 r-xp /usr/lib/libvasum.so.0.3.1
b6c48000 b6c4b000 r-xp /usr/lib/libttrace.so.1.1
b6c4d000 b6c51000 r-xp /usr/lib/libiniparser.so.0
b6c52000 b6c82000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c83000 b6c8c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c8d000 b6cb2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb3000 b6cc3000 r-xp /usr/lib/libunwind.so.8.0.1
b6ccd000 b6e7b000 r-xp /lib/libc-2.20-2014.11.so
b6e83000 b6fc6000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fc8000 b7020000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7021000 b7055000 r-xp /usr/lib/libsystemd.so.0.4.0
b7058000 b712c000 r-xp /usr/lib/libedje.so.1.13.0
b712f000 b715b000 r-xp /usr/lib/libecore.so.1.13.0
b716c000 b7392000 r-xp /usr/lib/libevas.so.1.13.0
b73ba000 b73d2000 r-xp /lib/libpthread-2.20-2014.11.so
b73d6000 b7750000 r-xp /usr/lib/libelementary.so.1.13.0
b7770000 b7774000 r-xp /usr/lib/libsmack.so.1.0.0
b7775000 b777e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b777f000 b7782000 r-xp /usr/lib/libdlog.so.0.0.0
b7783000 b7788000 r-xp /usr/lib/libbundle.so.0.1.22
b7789000 b778c000 r-xp /lib/libdl-2.20-2014.11.so
b778e000 b77b3000 r-xp /usr/lib/libaul.so.0.1.0
b77b6000 b77b8000 r-xp /usr/lib/libappsvc.so.0.1.0
b77b9000 b77be000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77bf000 b77c6000 r-xp /usr/lib/libappcore-efl.so.1.1
b77c8000 b77cd000 r-xp /usr/lib/libsys-assert.so
b77d0000 b77d1000 r-xp [vdso]
b77d1000 b77f3000 r-xp /lib/ld-2.20-2014.11.so
b77f5000 b77fd000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:2920)
Call Stack Count: 14
 0: fwrite + 0x50 (0xb6d2f090) [/lib/libc.so.6] + 0x62090
 1: (0xb353d56a) [/usr/lib/libcurl.so.4] + 0x1656a
 2: (0xb3555026) [/usr/lib/libcurl.so.4] + 0x2e026
 3: (0xb3560262) [/usr/lib/libcurl.so.4] + 0x39262
 4: curl_multi_perform + 0xf7 (0xb3560c77) [/usr/lib/libcurl.so.4] + 0x39c77
 5: (0xb35568a8) [/usr/lib/libcurl.so.4] + 0x2f8a8
 6: http_call + 0xff (0xb38387ff) [/opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky] + 0x17ff
 7:  + 0x0 (0xb3838257) [/opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky] + 0x1257
 8: (0xb77bb65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 9: appcore_efl_main + 0x327 (0xb77c2c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
10: ui_app_main + 0x140 (0xb77bbc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
11: main + 0x26c (0xb38381bc) [/opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky] + 0x11bc
12: (0xb77f7148) [/opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky] + 0xb77f7148
13: __libc_start_main + 0xde (0xb6ce4e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.iotjoussetluinogrotzky
Package ID : org.example.iotjoussetluinogrotzky
Version: 1.0.0
Package Type: tpk
App Name: iotjoussetluinogrotzky
App ID: org.example.iotjoussetluinogrotzky
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
taller( 3238): 
11-19 06:14:22.529+0900 D/rpm-installer( 3238): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
11-19 06:14:22.529+0900 D/rpm-installer( 3238): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
11-19 06:14:22.529+0900 D/rpm-installer( 3238): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
11-19 06:14:22.529+0900 D/rpm-installer( 3238): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
11-19 06:14:22.529+0900 D/rpm-installer( 3238): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
11-19 06:14:22.529+0900 D/rpm-installer( 3238): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
11-19 06:14:22.529+0900 D/rpm-installer( 3238): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
11-19 06:14:22.529+0900 D/rpm-installer( 3238): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
11-19 06:14:22.529+0900 D/rpm-installer( 3238): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
11-19 06:14:22.529+0900 D/rpm-installer( 3238): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
11-19 06:14:22.529+0900 D/rpm-installer( 3238): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
11-19 06:14:22.529+0900 D/rpm-installer( 3238): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
11-19 06:14:22.529+0900 D/rpm-installer( 3238): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
11-19 06:14:22.529+0900 D/rpm-installer( 3238): 
11-19 06:14:22.529+0900 D/rpm-installer( 3238): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
11-19 06:14:22.529+0900 D/rpm-installer( 3238): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
11-19 06:14:22.529+0900 D/rpm-installer( 3238): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
11-19 06:14:22.529+0900 D/rpm-installer( 3238): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
11-19 06:14:22.529+0900 D/rpm-installer( 3238): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
11-19 06:14:22.529+0900 D/rpm-installer( 3238): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
11-19 06:14:22.529+0900 D/rpm-installer( 3238): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
11-19 06:14:22.529+0900 D/rpm-installer( 3238): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
11-19 06:14:22.529+0900 D/rpm-installer( 3238): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
11-19 06:14:22.529+0900 D/rpm-installer( 3238): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
11-19 06:14:22.529+0900 D/rpm-installer( 3238): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
11-19 06:14:22.529+0900 D/rpm-installer( 3238): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
11-19 06:14:22.529+0900 D/rpm-installer( 3238): VhfnkHwPl
11-19 06:14:22.539+0900 D/CERT_SVC( 3238): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
11-19 06:14:22.539+0900 D/rpm-installer( 3238): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
11-19 06:14:22.539+0900 D/rpm-installer( 3238): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
11-19 06:14:22.539+0900 D/rpm-installer( 3238): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
11-19 06:14:22.539+0900 D/rpm-installer( 3238): rpm-installer.c: __ri_verify_file(336) > valid signature
11-19 06:14:22.549+0900 D/rpm-installer( 3238): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
11-19 06:14:22.549+0900 D/rpm-installer( 3238): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
11-19 06:14:22.549+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.iotjoussetluinogrotzky/signature1.xml) succeed.
11-19 06:14:22.549+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(60)
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(60)
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
11-19 06:14:22.549+0900 D/PKGMGR_INSTALLER( 3238): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.iotjoussetluinogrotzky] key[install_percent] value[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(60)
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(60)
11-19 06:14:22.549+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
11-19 06:14:22.549+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
11-19 06:14:22.549+0900 D/PKGMGR  ( 3236): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 2933): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/QUICKPANEL( 2933): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.iotjoussetluinogrotzky key:install_percent val:60
11-19 06:14:22.549+0900 D/PKGMGR  ( 3011): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 3063): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 2919): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/DATA_PROVIDER_MASTER( 2919): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.iotjoussetluinogrotzky] 60
11-19 06:14:22.549+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/PKGMGR  ( 2944): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
11-19 06:14:22.549+0900 D/PKGMGR  ( 2935): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29350002), pkg_type(tpk), pkgid(org.example.iotjoussetluinogrotzky), key(install_percent), val(60)
11-19 06:14:22.549+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 W/cluster-home( 2863): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.iotjoussetluinogrotzky]
11-19 06:14:22.549+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[60]
11-19 06:14:22.549+0900 D/cluster-home( 2863): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28630003] pkg_type[tpk] package[org.example.iotjoussetluinogrotzky] key[install_percent] val[60] pmsg[(null)]
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 15
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 15
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 1
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 3
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 3
11-19 06:14:22.559+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 3
11-19 06:14:22.569+0900 E/PKGMGR_CERT( 3238): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky, 5, _), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/shared, 5, _), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/res, 5, _), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/data, 2), result=[0]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/data], label=[$1$org.exam$sPKNbW%OX2wBnC0yLNuxV.]
11-19 06:14:22.679+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/cache], label=[$1$org.exam$sPKNbW%OX2wBnC0yLNuxV.]
11-19 06:14:22.689+0900 E/rpm-installer( 3238): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/data, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/lib, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/res, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/cache, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/tizen-manifest.xml, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/author-signature.xml, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/usr/apps/org.example.iotjoussetluinogrotzky/signature1.xml, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.689+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.iotjoussetluinogrotzky, /opt/share/packages/org.example.iotjoussetluinogrotzky.xml, 0, org.example.iotjoussetluinogrotzky), result=[0]
11-19 06:14:22.699+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.iotjoussetluinogrotzky] version set to [2.4] result=[0]
11-19 06:14:22.699+0900 D/rpm-installer( 3238): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
11-19 06:14:22.699+0900 D/rpm-installer( 3238): rpm-installer.c: __privilege_func(1046) > package_id=[org.example.iotjoussetluinogrotzky], privilege=[http://tizen.org/privilege/internet]
11-19 06:14:22.699+0900 D/rpm-installer( 3238): rpm-installer.c: __privilege_func(1046) > package_id=[org.example.iotjoussetluinogrotzky], privilege=[http://tizen.org/privilege/network.get]
11-19 06:14:22.719+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.iotjoussetluinogrotzky, 7), result=[0]
11-19 06:14:22.719+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(100)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(100)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
11-19 06:14:22.719+0900 D/PKGMGR_INSTALLER( 3238): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.iotjoussetluinogrotzky] key[install_percent] value[100]
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(100)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(install_percent), val(100)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
11-19 06:14:22.719+0900 D/rpm-installer( 3238): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.iotjoussetluinogrotzky) is done.
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(end), val(ok)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(end), val(ok)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
11-19 06:14:22.719+0900 D/PKGMGR_INSTALLER( 3238): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.iotjoussetluinogrotzky] key[end] value[ok]
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3238), zone(host), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(end), val(ok)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3238), pkg_typ(tpk), pkg_id(org.example.iotjoussetluinogrotzky), key(end), val(ok)
11-19 06:14:22.719+0900 D/PKGMGR  ( 3238): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
11-19 06:14:22.729+0900 D/PKGMGR  ( 3236): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/PKGMGR  ( 3063): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2933): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/QUICKPANEL( 2933): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.iotjoussetluinogrotzky key:install_percent val:100
11-19 06:14:22.729+0900 D/PKGMGR  ( 3011): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2919): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.iotjoussetluinogrotzky] 100
11-19 06:14:22.729+0900 D/PKGMGR  ( 2935): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29350002), pkg_type(tpk), pkgid(org.example.iotjoussetluinogrotzky), key(install_percent), val(100)
11-19 06:14:22.729+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 W/cluster-home( 2863): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/cluster-home( 2863): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28630003] pkg_type[tpk] package[org.example.iotjoussetluinogrotzky] key[install_percent] val[100] pmsg[(null)]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[install_percent], value=[100]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2944): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
11-19 06:14:22.729+0900 D/PKGMGR  ( 3236): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/PKGMGR  ( 3063): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/PKGMGR  ( 3011): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.iotjoussetluinogrotzky event_type=UPDATE event_state=COMPLETED progress=100 error=0
11-19 06:14:22.729+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 W/cluster-home( 2863): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 D/cluster-home( 2863): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2863): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/cluster-home( 2863): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28630003] pkg_type[tpk] package[org.example.iotjoussetluinogrotzky] key[end] val[ok] pmsg[(null)]
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
11-19 06:14:22.729+0900 D/PKGMGR  ( 2792): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/AUL_AMD ( 2792): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.iotjoussetluinogrotzky), key(end), value(ok)
11-19 06:14:22.729+0900 W/AUL_AMD ( 2792): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
11-19 06:14:22.729+0900 D/PKGMGR  ( 2919): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.iotjoussetluinogrotzky] ok
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.iotjoussetluinogrotzky], event_type[1]
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
11-19 06:14:22.729+0900 D/DATA_PROVIDER_MASTER( 2919): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 W/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
11-19 06:14:22.729+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2944): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
11-19 06:14:22.729+0900 D/cluster-home( 2863): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
11-19 06:14:22.729+0900 D/cluster-home( 2863): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 D/PKGMGR  ( 2935): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.729+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29350002), pkg_type(tpk), pkgid(org.example.iotjoussetluinogrotzky), key(end), val(ok)
11-19 06:14:22.729+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
11-19 06:14:22.729+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.iotjoussetluinogrotzky]
11-19 06:14:22.729+0900 D/AUL_AMD ( 2792): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.iotjoussetluinogrotzky, type:rpm
11-19 06:14:22.739+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.iotjoussetluinogrotzky] Name[iotjoussetluinogrotzky] Icon[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/res/iotjoussetluinogrotzky.png] enable[1] system[0]
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.iotjoussetluinogrotzky]
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.iotjoussetluinogrotzky
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.iotjoussetluinogrotzky], name[iotjoussetluinogrotzky], menuId[1], isPreload[0] isPreload[0]
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
11-19 06:14:22.739+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.iotjoussetluinogrotzky] Name[iotjoussetluinogrotzky] Icon[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/res/iotjoussetluinogrotzky.png] enable[1] system[0]
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [iotjoussetluinogrotzky]
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
11-19 06:14:22.739+0900 D/test-log( 2863): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/res/iotjoussetluinogrotzky.png], New icon path[/opt/usr/apps/org.example.iotjoussetluinogrotzky/shared/res/iotjoussetluinogrotzky.png]!!!!!
11-19 06:14:22.739+0900 D/cluster-home( 2863): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
11-19 06:14:22.739+0900 D/PKGMGR  ( 2933): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.iotjoussetluinogrotzky_1448168225], pkg_type=[tpk], pkgid=[org.example.iotjoussetluinogrotzky], key=[end], value=[ok]
11-19 06:14:22.739+0900 D/QUICKPANEL( 2933): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.iotjoussetluinogrotzky key:end val:ok
11-19 06:14:22.999+0900 E/PKGMGR_SERVER( 3177): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
11-19 06:14:23.279+0900 D/AUL_AMD ( 2792): amd_request.c: __request_handler(838) > __request_handler: 0
11-19 06:14:23.279+0900 D/AUL_AMD ( 2792): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.iotjoussetluinogrotzky
11-19 06:14:23.279+0900 D/PKGMGR_INFO( 2792): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
11-19 06:14:23.279+0900 D/PKGMGR_INFO( 2792): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
11-19 06:14:23.279+0900 I/AUL     ( 2792): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
11-19 06:14:23.279+0900 D/AUL     ( 2792): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 3289, pid = 3291
11-19 06:14:23.279+0900 D/PKGMGR_INFO( 2792): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
11-19 06:14:23.279+0900 D/PKGMGR_INFO( 2792): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
11-19 06:14:23.279+0900 I/AUL     ( 2792): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
11-19 06:14:23.279+0900 E/AUL_AMD ( 2792): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
11-19 06:14:23.279+0900 W/AUL_AMD ( 2792): amd_launch.c: _start_app(2233) > caller pid : 3291
11-19 06:14:23.279+0900 E/AUL_AMD ( 2792): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
11-19 06:14:23.279+0900 W/AUL_AMD ( 2792): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.iotjoussetluinogrotzky) pkgid(org.example.iotjoussetluinogrotzky) attribute(600)
11-19 06:14:23.289+0900 D/AUL_AMD ( 2792): amd_launch.c: _start_app(2648) > process_pool: false
11-19 06:14:23.289+0900 D/AUL_AMD ( 2792): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
11-19 06:14:23.289+0900 D/AUL_AMD ( 2792): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.iotjoussetluinogrotzky
11-19 06:14:23.289+0900 W/AUL_AMD ( 2792): amd_launch.c: _start_app(2665) > pad pid(-5)
11-19 06:14:23.289+0900 D/AUL_AMD ( 2792): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
11-19 06:14:23.289+0900 D/AUL_AMD ( 2792): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
11-19 06:14:23.289+0900 D/AUL     ( 2792): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
11-19 06:14:23.289+0900 D/RESOURCED( 2843): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.iotjoussetluinogrotzky, pkgid = org.example.iotjoussetluinogrotzky, flags = 1536
11-19 06:14:23.289+0900 D/RESOURCED( 2843): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.iotjoussetluinogrotzky, pkgname = org.example.iotjoussetluinogrotzky, ref = 1
11-19 06:14:23.289+0900 E/RESOURCED( 2843): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.iotjoussetluinogrotzky
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
11-19 06:14:23.289+0900 W/AUL_PAD ( 2916): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
11-19 06:14:23.289+0900 D/AUL     ( 2916): process_pool.c: __send_pkt_raw_data(219) > send(11) : 700 / 700
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 2920, bin path: /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky
11-19 06:14:23.289+0900 W/AUL_PAD ( 2916): launchpad.c: __send_result_to_caller(265) > Check app launching
11-19 06:14:23.289+0900 D/AUL_PAD ( 2916): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 700, pkt->len: 692
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.iotjoussetluinogrotzky, launchpad type: 0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.iotjoussetluinogrotzky
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.iotjoussetluinogrotzky
11-19 06:14:23.289+0900 D/AUL     ( 2920): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3027) is sent.
11-19 06:14:23.289+0900 D/AUL     ( 2920): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3027, signo: 10
11-19 06:14:23.289+0900 D/AUL     ( 2920): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.iotjoussetluinogrotzky / pkg_type : rpm / app_path : /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE1MTEwMzk2NjMvMjg1ODc5AA==##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzMjkxAA==##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky, real app argc: 8
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
11-19 06:14:23.289+0900 D/AUL_PAD ( 2920): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.iotjoussetluinogrotzky/bin/iotjoussetluinogrotzky)
11-19 06:14:23.289+0900 I/CAPI_APPFW_APPLICATION( 2920): app_main.c: ui_app_main(788) > app_efl_main
11-19 06:14:23.289+0900 D/LAUNCH  ( 2920): appcore-efl.c: appcore_efl_main(1692) > [iotjoussetluinogrotzky:Application:main:done]
11-19 06:14:23.289+0900 D/APP_CORE( 2920): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
11-19 06:14:23.289+0900 D/APP_CORE( 2920): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.iotjoussetluinogrotzky/res/locale
11-19 06:14:23.289+0900 D/APP_CORE( 2920): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
11-19 06:14:23.299+0900 D/APP_CORE( 2920): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
11-19 06:14:23.299+0900 D/AUL     ( 2920): app_sock.c: __create_server_sock(156) > pg path - already exists
11-19 06:14:23.299+0900 D/APP_CORE( 2920): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431b520
11-19 06:14:23.299+0900 D/LAUNCH  ( 2920): appcore-efl.c: __before_loop(1136) > [iotjoussetluinogrotzky:Platform:appcore_init:done]
11-19 06:14:23.299+0900 I/CAPI_APPFW_APPLICATION( 2920): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
11-19 06:14:23.319+0900 D/STARTER ( 2840): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb87fb848), lock_pid(2852)
11-19 06:14:23.319+0900 D/STARTER ( 2840): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb87fb848), lock_pid(2852)
11-19 06:14:23.319+0900 D/rpm-installer( 3238): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
11-19 06:14:23.319+0900 D/rpm-installer( 3238): rpm-appcore-intf.c: main(259) > ------------------------------------------------
11-19 06:14:23.319+0900 D/rpm-installer( 3238): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
11-19 06:14:23.319+0900 D/rpm-installer( 3238): rpm-appcore-intf.c: main(261) > ------------------------------------------------
11-19 06:14:23.319+0900 D/PKGMGR_SERVER( 3177): pkgmgr-server.c: sighandler(387) > child exit [3238]
11-19 06:14:23.319+0900 E/PKGMGR_SERVER( 3177): pkgmgr-server.c: sighandler(402) > child NORMAL exit [3238]
11-19 06:14:23.339+0900 D/debug   ( 2920): curl init
11-19 06:14:23.359+0900 I/CAPI_NETWORK_CONNECTION( 2920): connection.c: connection_create(408) > New handle created[0xb8d48aa8]
11-19 06:14:23.389+0900 D/AUL_PAD ( 2916): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
11-19 06:14:23.389+0900 W/AUL     ( 2792): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 2920, appid: org.example.iotjoussetluinogrotzky
11-19 06:14:23.389+0900 D/AUL     ( 2792): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-19 06:14:23.389+0900 E/AUL     ( 2792): simple_util.c: __trm_app_info_send_socket(330) > access
11-19 06:14:23.389+0900 D/AUL_AMD ( 2792): amd_launch.c: _start_app(2700) > add app group info
11-19 06:14:23.389+0900 E/AUL     ( 2792): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
11-19 06:14:23.389+0900 D/AUL_AMD ( 2792): amd_status.c: _status_add_app_info_list(427) > pid(2920) appid(org.example.iotjoussetluinogrotzky) pkgid(org.example.iotjoussetluinogrotzky) comp(uiapp)
11-19 06:14:23.389+0900 D/RESOURCED( 2843): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.iotjoussetluinogrotzky, 2920
11-19 06:14:23.389+0900 D/RESOURCED( 2843): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.iotjoussetluinogrotzky with pkgname
11-19 06:14:23.389+0900 E/RESOURCED( 2843): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.iotjoussetluinogrotzky
11-19 06:14:23.389+0900 D/RESOURCED( 2843): proc-main.c: resourced_proc_status_change(888) > available memory = 805
11-19 06:14:23.799+0900 W/CRASH_MANAGER( 2941): worker.c: worker_job(1204) > 1102920696f74151103966
