#!/bin/bash

cp ../IDHT/IDHT-Client/bin/Debug/IDHT-Client.exe .
cp ../IDHT/IDHT-Common/bin/Debug/IDHT-Common.dll .
if [ "$1" != "" ]
then
	./IDHT-Client.exe --Ice.Config=./client.cfg -g $1
fi
