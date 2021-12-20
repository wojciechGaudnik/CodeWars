function solution(M1, M2, m1, m2, V, T) {
    return (((m1 * 0.001 / M1 + m2 * 0.001 / M2) * 0.082 * (T + 273.15)) / V) * 1000;
}