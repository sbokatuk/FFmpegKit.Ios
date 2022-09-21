# FFmpegKit.Ios
Xamarin iOS bindings of FFmpegKit https://github.com/tanersener/ffmpeg-kit

- to run download release from https://github.com/tanersener/ffmpeg-kit/releases
- extract into lib

- to update ApiDefinitions and Structs
sharpie bind -output Binding -sdk iphoneos -scope Headers Headers/FFmpegKit.h -c
