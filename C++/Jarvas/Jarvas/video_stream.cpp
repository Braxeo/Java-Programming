#include "video_stream.h"

// windows display
#include <opencv2\highgui.hpp>
#include <iostream>


using namespace cv;
using namespace std;

video_stream::video_stream()
{
	stream1(0);
}


video_stream::~video_stream()
{
}


void video_stream::init()
{
	 // Obtains video device

	if (!stream1.isOpened())
	{
		cout << "Cannot open Camera";
	}

	
	stream1.read(cameraFrame);

	while (true)
	{
		

		imshow("Camera Output", cameraFrame);

		if (waitKey(30) >= 0)
		{
			break;
		}

	}
}

void video_stream::update()
{
	stream1.read(cameraFrame);
}

bool video_stream::haveCamFrame()
{
	return stream1.read(cameraFrame) ? true : false;
}

cv::Mat video_stream::getCamFrame()
{
	return cameraFrame;
}



