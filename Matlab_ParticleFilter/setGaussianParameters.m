%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 30/03/2010
% function: setGaussianParameters
% description:  create a vector of parameters
%               input: s,s1,s2,s3
%               output: parameters
function [p] = setGaussianParameters(media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z)
p=[media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z];