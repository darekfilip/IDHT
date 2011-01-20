#!/bin/bash

killall -s 9 icegridnode

rm -rf logs/
mkdir logs/
cd distrib
rm bin/*.dll
rm bin/*.bz2
cp ../../IDHT/IDHT-Services/bin/Debug/IDHT-*.dll bin/
rm IcePatch2.sum
icepatch2calc .
cd ..

ILE=4
if [ "$1" != "" ]
then
	ILE=$1
fi

rm -rf tmp
rm -rf conf
mkdir -p tmp/registry
mkdir conf
for I in `seq 1 $ILE`
do
	mkdir -p tmp/Node$I
	if [ $I == 1 ]
	then
		sed s/NodeX/Node$I/g node_plus_registry.cfg > conf/Node$I.cfg
	else
		sed s/NodeX/Node$I/g node_only.cfg > conf/Node$I.cfg
	fi
done

for I in `seq 1 $ILE`
do
	icegridnode --Ice.Config=conf/Node$I.cfg &
	echo "Started Node$I"
	sleep 1
done
