#!/bin/bash

cp ../IDHT/IDHT-Client/bin/Debug/IDHT-Client.exe .
cp ../IDHT/IDHT-Common/bin/Debug/IDHT-Common.dll .

for I in `seq 1 100`
do
	sum=`echo $I | md5sum | cut -d " " -f 1`
	./IDHT-Client.exe --Ice.Config=client.cfg -p $I $sum
	echo "INSERTED $I -> $sum"
done

for I in `seq 1 100`
do
	sum=`echo $I | md5sum | cut -d " " -f 1`
	res=`./IDHT-Client.exe --Ice.Config=client.cfg -g $I`
	echo $I $sum $res
	if [ "$sum" != "$res" ]
	then
		echo "FAILED FOR $I"
	fi
done
