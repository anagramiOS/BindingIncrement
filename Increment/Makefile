XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/Increment.xcodeproj
TARGET=Increment

all: libIncrement.a

libIncrement-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/libIncrement.a $@

libIncrement-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/libIncrement.a $@

libIncrement-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/libIncrement.a $@

libIncrement.a: libIncrement-i386.a libIncrement-armv7.a libIncrement-armv7s.a
	lipo -create -output $@ $^

clean:
	-rm -f *.a
