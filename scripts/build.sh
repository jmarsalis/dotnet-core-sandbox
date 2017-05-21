#!/usr/bin/env bash

# exit if any command fails
set -e

# the location of the output of the build output (must be an absolute path)
artifactsFolder="/tmp/build-artifacts/dotnet-core-sandbox"

# remove the drop location if it exists
if [ -d $artifactsFolder ]; then  
  rm -R $artifactsFolder
fi

# get the revision number for the version from the travis job
revision=${TRAVIS_JOB_ID:=1}  
revision=$(printf "%04d" $revision)

# restore and build the application
dotnet restore
#dotnet build -c Release
dotnet publish ./dotnet-core-sandbox.csproj -c Release -o $artifactsFolder --version-suffix=$revision