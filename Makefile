.PHONY: all, all-debug, build-release, build-debug, zip-release-nexusmods, zip-release-thunderstore, zip-debug-nexusmods, zip-debug-thunderstore

TARGET_FRAMEWORK = netstandard2.1
MOD_VERSION = 0.1.0

# TODO: figure out better way to handle; issue about system path env var
7Z := C:\Program Files\7-Zip\7z.exe

all: build-release zip-release-nexusmods zip-release-thunderstore
all-debug: build-debug zip-debug-nexusmods zip-debug-thunderstore

build-release:
	dotnet build -c "Release"

build-debug:
	dotnet build -c "Debug"

zip-release-nexusmods:
	$(7Z) a -bd -aoa -tzip "releases/UnencryptedSettings_Nexusmods_$(MOD_VERSION).zip" ./bin/Release/$(TARGET_FRAMEWORK)/UnencryptedSettings.dll

zip-release-thunderstore:
	$(7Z) a -bd -aoa -tzip "releases/UnencryptedSettings_$(MOD_VERSION).zip" ./manifest.json ./icon.png ./docs/README.md ./bin/Release/$(TARGET_FRAMEWORK)/UnencryptedSettings.dll

zip-debug-nexusmods:
	$(7Z) a -bd -aoa -tzip "releases/UnencryptedSettings_Nexusmods_$(MOD_VERSION)_Debug.zip" ./bin/Debug/$(TARGET_FRAMEWORK)/UnencryptedSettings.dll ./bin/Debug/$(TARGET_FRAMEWORK)/UnencryptedSettings.pdb

zip-debug-thunderstore:
	$(7Z) a -bd -aoa -tzip "releases/UnencryptedSettings_$(MOD_VERSION)_Debug.zip" ./manifest.json ./icon.png ./bin/Debug/$(TARGET_FRAMEWORK)/UnencryptedSettings.dll ./bin/Debug/$(TARGET_FRAMEWORK)/UnencryptedSettings.pdb
