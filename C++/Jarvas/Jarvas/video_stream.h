#pragma once
class video_stream
{
public:
	video_stream();
	~video_stream();
	void init();
	void update();
	bool haveCamFrame();
	cv::Mat getCamFrame();

	VideoCapture stream1;
	Mat cameraFrame;
};

