using MyArrayClassLibrary;
using MyConeClassLibrary;

ArrayClassLibrary arrayLibrary = new ArrayClassLibrary();

int[] sampleArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] reversedArray = arrayLibrary.ArrayWorker(sampleArray);
int[] arrayWithAdditionalItem = arrayLibrary.ArrayWorker(sampleArray, 3, 777);

Cone cone = new Cone(23, 12);
double coneFullSurfaceArea = cone.getFullSurfaceArea();
double coneBaseSurfaceArea = cone.getBaseSurfaceArea();