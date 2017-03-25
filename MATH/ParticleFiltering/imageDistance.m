% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 01/04/2010
% function: imageContraintDistance
% description:  Compute the image constraint distance with chain
%               input: captured image, and set of possible solutions
%               chains
%               output: image Distance per each chain
function [d]=imageDistance(image,chain)
d=[];
%binary image
bimage = im2bw(image,0);
bmodel = im2bw(chain2image(chain,[1,1]),0);
    
%model-(image*model)
cost = bmodel-(bimage.*bmodel);
d=[d;sum(sum(cost))];

