function dBScale(intensity) {
    return 10 * Math.log10(intensity / 10 ** -12)
}