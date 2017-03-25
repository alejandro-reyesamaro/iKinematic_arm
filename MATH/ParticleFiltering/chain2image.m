% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 17/03/2010
% function: chain2image
% description:  projection of the chain in an XY plane image, pensize
%               input: chain, 
%               output: image
function image=chain2image(chain,penSize,image)

if(nargin<3)
    resolution = [240,320];
    image = zeros(resolution);
    color = 255;  
end
if (nargin<2)
    penSize= [5,5];
end
if(nargin == 3)
    color=128;
    resolution = size(image);
end


%joints positions of the chain
points = chain2positions(chain);
%TODO
points=points*50;


points(:,1) = points(:,1)+resolution(1,2)/2;
points(:,2) = points(:,2)+resolution(1,1)/2;

% Transformacio mon-imatge
pointsIm= points;
pointsIm(:,1)= resolution(1,1)-points(:,2);
pointsIm(:,2)= points(:,1);

%drawLines parameters
startPos_endPos =[];
for i=1:size(pointsIm,1)-1,
    startPos_endPos = [startPos_endPos; pointsIm(i,1:2) pointsIm(i+1,1:2)];
end
startPos_endPos = round(startPos_endPos); %ATTENTION
image = drawLines(image, startPos_endPos, color, penSize);