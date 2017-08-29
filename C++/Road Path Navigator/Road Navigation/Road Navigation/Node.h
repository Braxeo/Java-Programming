#pragma once


class Node
{
public:
	Node(int lengthOfRoad, bool isTraversed, int UID);
	~Node();

	int lengthOfRoad;
	bool isTraversed;
	int UID;


	void setLength(int length);
	int getLength();

	void setTraversed(bool isTraversed);
	bool getTraversed();

	void setUID(int UID);
	int getUID();


};

