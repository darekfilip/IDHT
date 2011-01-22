#!/bin/bash

cp ../IDHT/IDHT-Client/bin/Debug/IDHT-Client.exe .
cp ../IDHT/IDHT-Common/bin/Debug/IDHT-Common.dll .
if [ "$1" != "" ]
then
	if [ "$2" != "" ]
	then
		./IDHT-Client.exe --Ice.Config=client.cfg -p $1 $2
	fi
fi
