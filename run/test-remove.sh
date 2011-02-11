#!/bin/bash

cp ../IDHT/IDHT-Client/bin/Debug/IDHT-Client.exe .
cp ../IDHT/IDHT-Common/bin/Debug/IDHT-Common.dll .


for I in `seq 1 10`
do
	sum=`echo $I | md5sum | cut -d " " -f 1`
	res=`./IDHT-Client.exe --Ice.Config=client.cfg -r $I`
	echo $I $sum $res
	if [ "$res" != "True" ]
	then
		echo "KEY NOT FOUND FOR $I"
	fi
done
