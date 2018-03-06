#include "main.h"

#include "face_recog.h"

#include "opencv2/core/core.hpp"
#include "opencv2/opencv.hpp"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/objdetect/objdetect.hpp"

#include <iostream>
#include <fstream>
#include <sstream>
// video feed

#include <opencv2\videoio.hpp>


// general incs.
#include <opencv2\core.hpp>
#include <opencv2\imgproc.hpp>




#include "video_stream.h"

using namespace cv;
using namespace std;

main::main()
{
}


main::~main()
{
}

int main(int argc, const char *argv[]) {

	video_stream vs = video_stream();

	vs.init();

	while (true)
	{
		vs.update();


		if (waitKey(30) >= 0)
		{
			break;
		}

	}
	
	return 0;
}