#!/bin/bash

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


