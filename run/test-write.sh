#!/bin/bash

cp ../IDHT/IDHT-Client/bin/Debug/IDHT-Client.exe .
cp ../IDHT/IDHT-Common/bin/Debug/IDHT-Common.dll .

for I in `seq 1 10`
do
	sum=`echo $I | md5sum | cut -d " " -f 1`
	./IDHT-Client.exe --Ice.Config=client.cfg -p $I $sum
	echo "INSERTED $I -> $sum"
done

